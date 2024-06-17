using CentroDeportivo1E.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace CentroDeportivo1E.Services
{
    internal class ActividadService
    {
        private readonly ConexionMysql conexionMysql = ConexionMysql.getInstance();

        public void InsertarActividad(Actividad actividad)
        {
            try
            {
                MySqlConnection conexion = conexionMysql.AbrirConexion();
                string procedimiento = "InsertarActividad";
                using (conexion)
                {
                    MySqlCommand comando = new MySqlCommand(procedimiento, conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@p_nombre", actividad.Nombre);
                    comando.Parameters.AddWithValue("@p_precio", actividad.Precio);

                    if (conexion.State != ConnectionState.Open)
                    {
                        conexion.Open();
                    }

                    comando.ExecuteNonQuery();
                    Console.WriteLine("Actividad insertada correctamente.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar la actividad: " + ex.Message);
            }
            finally
            {
                conexionMysql.CerrarConexion();
            }
        }

        public DataTable TraerTodasActividades()
        {
            DataTable dataTable = new DataTable();
            string procedimiento = "TraerActividadesActivas";

            try
            {
                MySqlConnection conexion = conexionMysql.AbrirConexion();
                conexion = conexionMysql.AbrirConexion();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(procedimiento, conexion);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                dataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexionMysql.CerrarConexion();
            }

            return dataTable;
        }
    }
}
