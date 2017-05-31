using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PlayBetWin_Administrador.Conexiones
{
    class BaseDatos
    {
        private MySqlConnection cnx;

        public BaseDatos()
        {
            cnx = new MySqlConnection("SERVER=localhost;DATABASE=playbetwin;UID=root;PWD=''");
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

        //Se usa para eliminar, insertar o modificar 
        public void modificarTablas(String sentencia)
        {
            try
            {
                MySqlCommand c = new MySqlCommand();
                c.Connection = cnx;
                c.CommandText = sentencia;
                c.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error al modificar" + ex.ToString());
            }
        }

        //Para comprobar si ya existe
        public bool existe(String consulta)
        {
            bool noEncontrado = true;

            MySqlCommand c = new MySqlCommand();
            MySqlDataReader d;
            try
            {
                c.Connection = cnx;
                c.CommandText = consulta;
                d = c.ExecuteReader();
                if (d.HasRows)
                {
                    while (d.Read())
                    {
                        noEncontrado = false;
                        break; 
                    }

                }
                d.Close();
            }
            catch (MySqlException ex)
            {

            }

            return noEncontrado; 
        }
    }
}
