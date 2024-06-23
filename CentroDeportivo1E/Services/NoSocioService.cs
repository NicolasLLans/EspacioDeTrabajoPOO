using CentroDeportivo1E.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace CentroDeportivo1E.Services
{
    internal class NoSocioService
    {
        private readonly ConexionMysql conexionMysql = ConexionMysql.getInstance();
        public void InsertarNoSocio(NoSocio noSocio)
        {
            try
            {
                MySqlConnection conexion = conexionMysql.AbrirConexion();
                string procedimiento = "InsertarNoSocio";

                using (conexion)
                {
                    MySqlCommand comando = new MySqlCommand(procedimiento, conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@p_nombre", noSocio.Nombre);
                    comando.Parameters.AddWithValue("@p_apellido", noSocio.Apellido);
                    comando.Parameters.AddWithValue("@p_dni", noSocio.Dni);
                    comando.Parameters.AddWithValue("@p_direccion", noSocio.Direccion);
                    comando.Parameters.AddWithValue("@p_telefono", noSocio.Telefono);
                    comando.Parameters.AddWithValue("@p_email", noSocio.Email);
                    comando.Parameters.AddWithValue("@p_fechaAlta", noSocio.FechaAlta);
                    comando.Parameters.AddWithValue("@p_aptoFisico", noSocio.AptoFisico);

                    comando.ExecuteNonQuery();
                }

                Console.WriteLine("Socio cargado correctamente.");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al cargar socio: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general al nuevo socio: " + ex.Message);
            }
            finally
            {
                conexionMysql.CerrarConexion();
            }
        }
        
    }
}
