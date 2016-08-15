using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace prjEleicao
{
    public class Modulo
    {
        //FIELDS
        private int cd_modulo;

        //PROPRIEDADES
        public int Código
        {
            get {
                return cd_modulo;
            }
        }

        public string Nome
        {
            get;
            set;
        }

        public String Componente
        {
            get;
            set;
        }

        //METODOS

        public Modulo(int codigo, string nome, string componente){
            cd_modulo = codigo;
            Nome = nome;
            Componente = componente;
        }

        public static List<Modulo> Consultar(string termo = null){
            string cSQL = "SELECT * FROM modulo;";
            if (termo != null) {
                cSQL = "SELECT * FROM modulo WHERE nm_modulo like '%" + termo + "%'";
                cSQL += "ORDER BY CASE WHEN nm_modulo like '" + termo + "%' THEN 0 ";
                cSQL += "WHEN nm_modulo like '%" + termo + "' THEN 1 ";
                cSQL += "ELSE 2 END";
            }

            MySqlCommand consultar = new MySqlCommand(cSQL, UsoComum.Conexao);
            MySqlDataReader dados = consultar.ExecuteReader();

            List<Modulo> listaModulos = new List<Modulo>();

            while (dados.Read()) {
                listaModulos.Add(new Modulo(int.Parse(dados["cd_modulo"].ToString()), dados["nm_modulo"].ToString(), dados["nm_componente"].ToString()));
            }

            dados.Close();
            return listaModulos;
        }
    }
}
