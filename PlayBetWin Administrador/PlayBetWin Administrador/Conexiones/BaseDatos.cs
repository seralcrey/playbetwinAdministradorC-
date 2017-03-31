using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace PlayBetWin_Administrador.Conexiones
{
    class BaseDatos
    {
        private MySqlConnection cnx;

        public BaseDatos()
        {
            cnx = new MySqlConnection("SERVER=localhost;DATABASE=prueba;UID=root;PWD=''");
        }
        public int Conectar()
        {
            int resultado = -1;
            try
            {
                cnx.Open();
                if (cnx.State == ConnectionState.Open)
                    resultado = 1;
            }
            catch (MySqlException ex)
            {

            }
            return resultado;
        }
        public int Desconectar()
        {
            int resultado = -1;
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
                resultado = 1;
            }
            return resultado;
        }

        public List<List<String>> cogerLista(String consulta)
        {
            List<List<String>> lista = new List<List<String>>();
            MySqlCommand c = new MySqlCommand();
            MySqlDataReader d;
            try
            {
                c.Connection = cnx;
                c.CommandText = consulta;
                d = c.ExecuteReader();
                if (d.HasRows)
                {
                    while (d.Read()) {
                        List<String> lista2 = new List<String>();
                        for (int i = 0; i < d.FieldCount; i++)
                            lista2.Add(d.GetString(i));
                        lista.Add(lista2);
                    }
                
                }
                d.Close();

            }
            catch (MySqlException ex)
            {

            }
            return lista;
        }
    }
}
