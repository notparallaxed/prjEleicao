using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace prjEleicao
{
    class Candidato
    {
        //FIELDS
        private int cd_candidato;
        private string nm_candidato;
        private string sg_partido;
        
        //PROPERTIES
        public int Codigo{
            get{return cd_candidato;}
            set{cd_candidato = value;}
        }

        public string Nome {
            get { return nm_candidato; }
            set { nm_candidato = value;}
        }

        public string Sigla
        {
            get { return sg_partido; }
            set { sg_partido = value; }
        }

        //CONSTRUCTOR
        public Candidato(int codigo, string nome, string sigla)
        {
            nm_candidato = nome;
            cd_candidato = codigo;
            sg_partido = sigla;
        }

        //METHODES;

        public static List<Candidato> PesquisarCandidatos(string termo){
            
            string cSQL = "SELECT * FROM candidato ORDER BY nm_candidato ASC";
            if (!(termo == "" || termo == null))
            {
                cSQL = "SELECT * FROM candidato WHERE nm_candidato like'%" + termo + "%' OR sg_partido like '" + termo + "%' ";
                cSQL += "ORDER BY CASE WHEN nm_candidato like '" + termo + "%' THEN 0 ";
                cSQL += "WHEN nm_candidato like '%" + termo + "' THEN 1 ";
                cSQL += "ELSE 2 END";
            }

            MySqlCommand listar = new MySqlCommand(cSQL, UsoComum.Conexao);
            MySqlDataReader dados = listar.ExecuteReader();

            List<Candidato> listaCandidatos = new List<Candidato>();

            while (dados.Read()) { 
                listaCandidatos.Add(new Candidato(int.Parse(dados["cd_candidato"].ToString()), dados["nm_candidato"].ToString(), dados["sg_partido"].ToString()));
            }

            dados.Close();

            return listaCandidatos;
        }

        public static void Excluir(string codigoCandidato) {
            string cSQL = "DELETE FROM candidato WHERE cd_candidato = '" + codigoCandidato + "';";
            MySqlCommand deletar = new MySqlCommand(cSQL, UsoComum.Conexao);

            deletar.ExecuteNonQuery();
        }

        public void Salvar() {
            string cSQL = "INSERT INTO candidato(cd_candidato, nm_candidato, sg_partido) values('" + cd_candidato + "', '" + nm_candidato + "', '" + sg_partido + "');";
            MySqlCommand inserir = new MySqlCommand(cSQL, UsoComum.Conexao);

            inserir.ExecuteNonQuery();
            
        }

        public void Editar() {
            string cSQL = "UPDATE candidato SET nm_candidato = '" + nm_candidato + "', sg_partido = '" + sg_partido + "' WHERE cd_candidato='" + cd_candidato + "';";
            MySqlCommand atualizar = new MySqlCommand(cSQL, UsoComum.Conexao);

            atualizar.ExecuteNonQuery();
                        
        }
        

    }
}
