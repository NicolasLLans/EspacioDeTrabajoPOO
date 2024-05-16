using System;
using System.Windows.Forms; // Necesario para mostrar mensajes de MessageBox
using MySql.Data.MySqlClient;

namespace CentroDeportivo1E.Models
{
    internal class ConexionMysql
    {
        string cadenaConexion = @"Server=boqb2fw0r8paaef8nwrw-mysql.services.clever-cloud.com; 
                                  Port=3306; 
                                  Database=boqb2fw0r8paaef8nwrw; 
                                  Uid=ugpeqcu41vayuvw1; 
                                  Pwd=PSBRCFiK3DIAAgGaoG2p;";

        public MySqlConnection abrirConexion()
        {
            MySqlConnection conectarMySql = new MySqlConnection(); // Crea una nueva instancia de MySqlConnection aquí

            try
            {
                conectarMySql.ConnectionString = cadenaConexion;
                conectarMySql.Open();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("No se pudo conectar a la Base de datos, Error: " + e.ToString());
            }

            return conectarMySql;
        }

        public void cerrarConexion(MySqlConnection conexion)
        {
            try
            {
                conexion.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error al cerrar la conexión: " + e.ToString());
            }
        }
    }
}
