using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace prjEleicao
{
    public class Usuario
    {

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

        public Usuario(string nome, string nomeLogin) {
            Nome = nome;
            NomeLogin = nomeLogin;
            Modulos = new List<int>();
        }

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

        public void Editar(string novasenha = null) {
            string cSQL = "UPDATE usuario SET nm_usuario = '" + Nome + "' WHERE nm_login = '" + NomeLogin + "';";
            
            if (novasenha != null) {
                cSQL = "UPDATE usuario SET nm_usuario='" + Nome + "', nm_senha=md5('"+ novasenha +"') WHERE nm_login = '" + NomeLogin + "';";
            }

            MySqlCommand editar = new MySqlCommand(cSQL, UsoComum.Conexao);

            editar.ExecuteNonQuery();
        }

        /*
        public static List<Usuario> Consultar(string termo = null) { 
            cSQL = 
        }
        */
    }
}
