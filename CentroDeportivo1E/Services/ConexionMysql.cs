using CentroDeportivo1E.Forms;
using MySql.Data.MySqlClient;


namespace CentroDeportivo1E.Services
{
    internal class ConexionMysql
    {
        private static string connectionString = "";
        private MySqlConnection? connection = null;
        private static ConexionMysql? instance = null;

        private ConexionMysql() { }
        public static void Initialize(string servidor, string puerto, string baseDatos, string usuario, string contrasena)
        {
            connectionString = $"Server ={servidor}; Port ={puerto}; Database ={baseDatos}; Uid ={usuario}; Pwd ={contrasena};";
        }

        public MySqlConnection AbrirConexion()
        {
            if (connection == null)
            {
                if (string.IsNullOrEmpty(connectionString))
                {
                    var frmConexion = new FormConexion();
                    frmConexion.ShowDialog();
                }
                connection = new MySqlConnection(connectionString);
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    connectionString = "";
                    connection = null;
                    throw ex;
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
