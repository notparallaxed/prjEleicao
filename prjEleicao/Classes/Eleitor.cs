using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace prjEleicao
{
    class Eleitor
    {
        //PROPRIEDADES

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }

        public Eleitor(int codigo, string nome, string cpf) {
            Codigo = codigo;
            Nome = nome;
            CPF = cpf;
        }

        //METHODES

        //CONSULTAR
        public static List<Eleitor> Consultar(string termo = null) {
            string cSQL = "SELECT * FROM eleitor;";

            if (termo != null) { 
                cSQL = "SELECT * FROM eleitor WHERE nm_eleitor like '%"+ termo +"%' or cd_cpf_eleitor like '%"+ termo +"%' ";
                cSQL +="ORDER BY CASE WHEN nm_eleitor like '"+ termo +"%' THEN 0 ";
                cSQL +="WHEN nm_eleitor like '%"+ termo +"' THEN 1 ";
                cSQL +="ELSE 2 END;";
            }

            MySqlCommand consultar = new MySqlCommand(cSQL, UsoComum.Conexao);
            MySqlDataReader dados = consultar.ExecuteReader();

            List<Eleitor> listaEleitores = new List<Eleitor>();

            while (dados.Read()) {
                listaEleitores.Add(new Eleitor(int.Parse(dados[0].ToString()), dados[1].ToString(), dados[2].ToString()));
            }

            dados.Close();

            return listaEleitores;

        } 

        //INSERIR
        public void Salvar() {
            string cSQL = "INSERT INTO eleitor SELECT max(cd_eleitor) + 1, '" + Nome + "' , '" + CPF + "' from eleitor;";

            MySqlCommand salvar = new MySqlCommand(cSQL, UsoComum.Conexao);

            salvar.ExecuteNonQuery();

        }

        //EDITAR
        public void Editar() {
            string cSQL = "UPDATE eleitor SET nm_eleitor='" + Nome + "', cd_cpf_eleitor='" + CPF + "' WHERE cd_eleitor="+ Codigo +";";

            MySqlCommand editar = new MySqlCommand(cSQL, UsoComum.Conexao);

            editar.ExecuteNonQuery();
        }

        //EXCLUIR
        public static void Excluir(int codigo) {
            string cSQL = "DELETE FROM eleitor WHERE cd_eleitor=" + codigo + ";";

            MySqlCommand excluir = new MySqlCommand(cSQL, UsoComum.Conexao);

            excluir.ExecuteNonQuery();
        }

    }
}
