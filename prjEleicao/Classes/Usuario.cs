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

    }
}
