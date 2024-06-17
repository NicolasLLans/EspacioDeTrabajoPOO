using MySql.Data.MySqlClient;

namespace CentroDeportivo1E.Services
{
    internal class ConexionMysql
    {
        private string servidor;
        private string puerto;
        private string baseDatos;
        private string usuario;
        private string contrasena;

        public ConexionMysql(string servidor, string puerto, string baseDatos, string usuario, string contrasena)
        {
            this.servidor = servidor;
            this.puerto = puerto;
            this.baseDatos = baseDatos;
            this.usuario = usuario;
            this.contrasena = contrasena;
        }

        private string CadenaConexion => $"Server={servidor}; Port={puerto}; Database={baseDatos}; Uid={usuario}; Pwd={contrasena};";

        public MySqlConnection AbrirConexion()
        {
            MySqlConnection conectarMySql = new MySqlConnection();

            try
            {
                conectarMySql.ConnectionString = CadenaConexion;
                conectarMySql.Open();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("No se pudo conectar a la Base de datos, Error: " + e.ToString());
            }

            return conectarMySql;
        }

        public void CerrarConexion(MySqlConnection conexion)
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
