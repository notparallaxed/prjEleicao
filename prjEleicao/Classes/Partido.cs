using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace prjEleicao
{
    class Partido
    {
        private string _sg_partido;
        private string _nm_partido;
        private int _nr_partido;

        //PROPERTIES

        public string Sigla {
            get { return _sg_partido;}
            set { _sg_partido = value;}
        }

        public string Nome {
            get { return _nm_partido; }
            set { _nm_partido = value; }
        }

        public int Numero {
            get { return _nr_partido; }
            set { _nr_partido = value; }
        }

        //MÉTODOS

        public static List<Partido> PesquisarPartidos(string termo) {
            string cSQL = "SELECT * FROM partido ORDER BY nm_partido ASC";
            if (!(termo == "" || termo == null))
            {
                cSQL = "SELECT * FROM partido WHERE nm_partido like'%" + termo + "%' OR sg_partido like '" + termo + "%' OR cd_nr_partido like '%" + termo + "%' ";
                cSQL += "ORDER BY CASE WHEN nm_partido like '" + termo + "%' THEN 0 ";
                cSQL += "WHEN nm_partido like '%" + termo + "' THEN 1 ";
                cSQL += "ELSE 2 END";
            }

            MySqlCommand listar = new MySqlCommand(cSQL, UsoComum.Conexao);
            MySqlDataReader dados = listar.ExecuteReader();

            List<Partido> partidos = new List<Partido>();

            while (dados.Read()) {
                partidos.Add(new Partido(dados["sg_partido"].ToString(), dados["nm_partido"].ToString(), int.Parse(dados["cd_nr_partido"].ToString())));
            }
            
            dados.Close();

            return partidos;
        }

        public static void Excluir(string sg_partido){
            string cSQL = "DELETE FROM partido WHERE sg_partido = '" + sg_partido + "';";
            MySqlCommand excluir = new MySqlCommand(cSQL, UsoComum.Conexao);
            excluir.ExecuteNonQuery();
        }

        public void Salvar(){
            string cSQL = "INSERT INTO partido(sg_partido, nm_partido, cd_nr_partido) values('"+ _sg_partido +"', '" +_nm_partido + "', '" + _nr_partido + "');";
            MySqlCommand inserir = new MySqlCommand(cSQL, UsoComum.Conexao);
            inserir.ExecuteNonQuery();  
        }

        public void Editar() {
            string cSQL = "UPDATE partido SET nm_partido='" + _nm_partido + "', cd_nr_partido='" + _nr_partido + "' WHERE sg_partido='" + _sg_partido + "';";
            MySqlCommand atualizar = new MySqlCommand(cSQL, UsoComum.Conexao);
            atualizar.ExecuteNonQuery();  
        }

        //CONSTRUTOR

        public Partido(string sigla, string nome, int numero) {
            _sg_partido = sigla;
            _nm_partido = nome;
            _nr_partido = numero;
        }

    }
}
