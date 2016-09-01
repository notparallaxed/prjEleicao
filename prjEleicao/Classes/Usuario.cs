using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace prjEleicao
{
    public class Usuario
    {
        private string _senha;

        public string Nome
        {
            get;
            set;
        }

        public string NomeLogin
        {
            get;
            set;
        }

        public List<int> Modulos
        {
            get;
            set;
        }

        public Usuario(string nome, string nomeLogin, string senha = null) {
            Nome = nome;
            NomeLogin = nomeLogin;
            Modulos = new List<int>();
            _senha = senha;
        }

        //Realizar Login
        public static Usuario Login(string nomelogin, string senha) {
            string cSQL = "SELECT * FROM usuario WHERE nm_login='" + nomelogin + "' && nm_senha=md5('" + senha + "');";

            MySqlCommand login = new MySqlCommand(cSQL, UsoComum.Conexao);

            MySqlDataReader dados = login.ExecuteReader();

            if (dados.Read()) {
                Usuario atual = new Usuario(dados["nm_usuario"].ToString(), dados["nm_login"].ToString());
                dados.Close();
                return atual ;
            }
            dados.Close();
            return null;
        }

        //Puxa os módulos referentes ao usuário já cadastrado
        public void CarregarModulos() {
            string cSQL = "SELECT * FROM permissao_acesso WHERE nm_login = '" + NomeLogin + "'";
            MySqlCommand listarmodulos = new MySqlCommand(cSQL, UsoComum.Conexao);

            MySqlDataReader dados = listarmodulos.ExecuteReader();

            Modulos.Clear();

            while (dados.Read()) {
                Modulos.Add(int.Parse(dados["cd_modulo"].ToString()));
            }

            dados.Close();
        }

        //CONSULTAR
        public static List<Usuario> Consultar(string termo = null)
        {
            string cSQL = "SELECT * FROM usuario ORDER BY nm_usuario";

            if (termo != null)
            {
                cSQL = "SELECT * FROM usuario WHERE nm_usuario like '%"+ termo +"%' OR nm_login like '%"+termo+"%' ";
                cSQL += "ORDER BY CASE WHEN nm_usuario like '" + termo + "%' THEN 0 ";
                cSQL += "WHEN nm_usuario like '%" + termo + "' THEN 1 ";
                cSQL += "ELSE 2 END";
            }

            MySqlCommand consultar = new MySqlCommand(cSQL, UsoComum.Conexao);
            MySqlDataReader dados = consultar.ExecuteReader();

            List<Usuario> listaUsuarios = new List<Usuario>();

            while (dados.Read())
            {
                listaUsuarios.Add(new Usuario(dados["nm_usuario"].ToString(), dados["nm_login"].ToString()));
            }

            dados.Close();

            foreach (Usuario user in listaUsuarios)
            {
                user.CarregarModulos();
            }

            return listaUsuarios;

        }

        //EDITAR
        public void Editar() {
            string cSQL = "UPDATE usuario SET nm_usuario = '" + Nome + "' WHERE nm_login = '" + NomeLogin + "';";
            
            if (_senha != null) {
                cSQL = "UPDATE usuario SET nm_usuario='" + Nome + "', nm_senha=md5('"+ _senha +"') WHERE nm_login = '" + NomeLogin + "';";
            }

            MySqlCommand editar = new MySqlCommand(cSQL, UsoComum.Conexao);

            editar.ExecuteNonQuery();

            _senha = null;

            //editar modulos
            cSQL = "DELETE FROM permissao_acesso WHERE nm_login='"+ NomeLogin+"';";
            MySqlCommand excluirmodulosantigos = new MySqlCommand(cSQL, UsoComum.Conexao);
            excluirmodulosantigos.ExecuteNonQuery();

            foreach (int mod in Modulos)
            {
                cSQL = "INSERT INTO permissao_acesso VALUES('" + NomeLogin + "', " + mod + ");";
                MySqlCommand salvarmodulo = new MySqlCommand(cSQL, UsoComum.Conexao);
                salvarmodulo.ExecuteNonQuery();
            }
        }

        //INSERIR
        public void Salvar() {
            string cSQL = "INSERT INTO usuario VALUES('" + NomeLogin + "', '" + Nome + "', md5('" + _senha + "'));";
            MySqlCommand salvar = new MySqlCommand(cSQL, UsoComum.Conexao);
            
            salvar.ExecuteNonQuery();

            _senha = null;

            foreach (int mod in Modulos)
            {
                cSQL = "INSERT INTO permissao_acesso VALUES('" + NomeLogin + "', " + mod + ");";
                MySqlCommand salvarmodulo = new MySqlCommand(cSQL, UsoComum.Conexao);
                salvarmodulo.ExecuteNonQuery();
            }
        }

        //EXCLUIR
        public static void Excluir(string nomelogin) {
            string cSQL = "DELETE FROM permissao_acesso WHERE nm_login='" + nomelogin + "';";
            MySqlCommand deletarmods = new MySqlCommand(cSQL, UsoComum.Conexao);

            deletarmods.ExecuteNonQuery();

            cSQL = "DELETE FROM usuario WHERE nm_login='" + nomelogin + "';";
            MySqlCommand deletar = new MySqlCommand(cSQL, UsoComum.Conexao);

            deletar.ExecuteNonQuery();
        }

    }
}
