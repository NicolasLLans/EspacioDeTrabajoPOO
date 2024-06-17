using MySql.Data.MySqlClient;

namespace CentroDeportivo1E.Services
{
    internal class ConexionMysql
    {
        private static string connectionString = "";
        private MySqlConnection? connection = null;
        private static ConexionMysql? instance = null;

        public ConexionMysql(string servidor, string puerto, string baseDatos, string usuario, string contrasena)
        {
            connectionString = $"Server ={servidor}; Port ={puerto}; Database ={baseDatos}; Uid ={usuario}; Pwd ={contrasena};";
        }
        public ConexionMysql() { }

        public MySqlConnection AbrirConexion()
        {
            if (connection == null)
            {
                connection = new MySqlConnection(getStringConnection());
                try
                {
                    connection.Open();
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("No se pudo conectar a la Base de datos, Error: " + e.ToString());
                    throw;
                }
            }
            return connection;
        }

        public static ConexionMysql getInstance()
        {
            if (instance == null)
            {
                instance = new ConexionMysql();
            }
            return instance;
        }

        public static string getStringConnection()
        {
            return connectionString;
        }

        public void CerrarConexion()
        {
            if (connection != null)
            {
                try
                {
                    this.connection.Close();
                    connection = null;
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Error al cerrar la conexión: " + e.ToString());
                }
            }
        }
    }
}
