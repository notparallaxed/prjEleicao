using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace prjEleicao
{
    class Cargo
    {
        private int cd_cargo;
        private string nm_cargo;
        private int qt_digitos_cargo;

        //PROPERTIES

        public int Codigo {
            get { return cd_cargo; }
            set { cd_cargo = value; }
        }

        public string Nome {
            get { return nm_cargo; }
            set { nm_cargo = value; }
        }

        public int QuantidadeDigitos {
            get { return qt_digitos_cargo; }
            set { qt_digitos_cargo = value; }
        }

        //MÉTODOS
        public static List<Cargo> PesquisarCargos(string termo) {
            
            string cSQL = "SELECT * FROM cargo ORDER BY nm_cargo ASC";
            if (!(termo == "" || termo == null))
            {
                cSQL = "SELECT * FROM cargo WHERE nm_cargo like'%" + termo + "%'";
                cSQL += "ORDER BY CASE WHEN nm_cargo like '" + termo + "%' THEN 0 ";
                cSQL += "WHEN nm_cargo like '%" + termo + "' THEN 1 ";
                cSQL += "ELSE 2 END";
            }
            
            MySqlCommand listar = new MySqlCommand(cSQL, UsoComum.Conexao);
            MySqlDataReader dados = listar.ExecuteReader();

            List<Cargo> cargos = new List<Cargo>();

            while (dados.Read())
            {
                cargos.Add(new Cargo(int.Parse(dados["cd_cargo"].ToString()), dados["nm_cargo"].ToString(), int.Parse(dados["qt_digitos_cargo"].ToString())));
            }

            dados.Close();

            return cargos;
        }
        public static void Excluir(int codigo)
        {
            string cSQL = "DELETE FROM cargo WHERE cd_cargo=" + codigo + ";";
            MySqlCommand deletar = new MySqlCommand(cSQL, UsoComum.Conexao);

            deletar.ExecuteNonQuery();
        }
        public void Salvar() { 
            string cSQL = "INSERT INTO cargo(cd_cargo, nm_cargo, qt_digitos_cargo) SELECT max(cd_cargo) + 1, '"+ nm_cargo +"', '"+ qt_digitos_cargo +"' FROM cargo;";
            MySqlCommand inserir = new MySqlCommand(cSQL, UsoComum.Conexao);

            inserir.ExecuteNonQuery();
        }
        public void Editar() {
            string cSQL = "UPDATE cargo SET nm_cargo='" + nm_cargo + "', qt_digitos_cargo='" + qt_digitos_cargo + "' WHERE cd_cargo=" + cd_cargo + ";";
            MySqlCommand editar = new MySqlCommand(cSQL, UsoComum.Conexao);

            editar.ExecuteNonQuery();
        }

    
        //CONSTRUTOR
        public Cargo(int codigo, string nome, int quantidadeDigitos) {
            cd_cargo = codigo;
            nm_cargo = nome;
            qt_digitos_cargo = quantidadeDigitos;
        }

    }

}
