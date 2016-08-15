using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace prjEleicao
{
    class Urna
    {
        //PROPRIEDADES
        public int Codigo
        {
            get;
            set;
        }

        //CONSTRUTOR
        public Urna(int codigo_urna) {
            Codigo = codigo_urna;
        }

        //MÉTODOS
        public static List<Urna> Consultar(string termo = null) {
            string cSQL = "SELECT * FROM urna ORDER BY cd_urna ASC";
            //if any query term is especified
            if (termo != null) {
                cSQL = "SELECT * FROM urna WHERE cd_urna like '%" + termo + "%'";
                cSQL += "ORDER BY CASE WHEN cd_urna like '" + termo + "%' THEN 0 ";
                cSQL += "WHEN cd_urna like '%"+termo+"' THEN 1 ";
                cSQL += "ELSE 2 END";
            }

            MySqlCommand listar = new MySqlCommand(cSQL, UsoComum.Conexao);
            MySqlDataReader dados = listar.ExecuteReader();

            List<Urna> listaUrnas = new List<Urna>();

            while (dados.Read()) { 
                listaUrnas.Add(new Urna(int.Parse(dados["cd_urna"].ToString())));
            }

            dados.Close();

            return listaUrnas;
        }

        public int Salvar() {
            string cSQL = "INSERT INTO urna VALUES('" + Codigo + "');";
            MySqlCommand salvar = new MySqlCommand(cSQL, UsoComum.Conexao);

            try
            {
                salvar.ExecuteNonQuery();
            }
            catch (MySqlException e) {
                return e.Number;
            }

            return 0;
        }

        public static void Excluir(int codigo_urna) {
            string cSQL = "DELETE FROM urna WHERE cd_urna=" + codigo_urna + "";
            MySqlCommand deletar = new MySqlCommand(cSQL, UsoComum.Conexao);

            deletar.ExecuteNonQuery();

        } 
        
    }
}
