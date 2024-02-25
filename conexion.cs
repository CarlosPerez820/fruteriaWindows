using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sistema_Fruteria
{
    public class conexion
    {
        public void pruebaConexion()
        {
            string connectionString = "server=localhost;user id=root;password=123456;database=fruteria";

            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                Debug.WriteLine("Conexión exitosa a la base de datos MySQL.");
               // MessageBox.Show("Conexion exitosa");
                // Aquí puedes realizar otras operaciones de base de datos si lo deseas
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine("Error al conectar a la base de datos MySQL: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }
    }
}
