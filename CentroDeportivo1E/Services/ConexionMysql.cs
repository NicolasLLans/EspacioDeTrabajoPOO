using MySql.Data.MySqlClient;

namespace CentroDeportivo1E.Services
{
    internal class ConexionMysql
    {
        string cadenaConexion = @"Server=localhost; 
                          Port=3306; 
                          Database=centrodeportivo1e; 
                          Uid=root; 
                          Pwd=root;";

        public MySqlConnection abrirConexion()
        {
            MySqlConnection conectarMySql = new MySqlConnection();

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
