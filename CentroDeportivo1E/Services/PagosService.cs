using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace CentroDeportivo1E.Services
{
    internal class PagosService
    {
        private readonly ConexionMysql conexionMysql;

        // Constructor que recibe las credenciales de conexión
        public PagosService(string servidor, string puerto, string baseDatos, string usuario, string contrasena)
        {
            this.conexionMysql = new ConexionMysql(servidor, puerto, baseDatos, usuario, contrasena);
        }

        public DataTable ListadoPagos(int IdPersona)
        {
            MySqlConnection conexion = null;
            DataTable dataTable = new DataTable();
            string procedimiento = "ListadoPagos";

            try
            {
                conexion = conexionMysql.AbrirConexion();

                MySqlCommand comando = new MySqlCommand(procedimiento, conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@p_IdPersona", IdPersona);

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(comando);
                dataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (conexion != null)
                {
                    conexionMysql.CerrarConexion(conexion);
                }
            }

            return dataTable;
        }

        public DataTable TraerTipoPago(int IdPersona)
        {
            MySqlConnection conexion = null;
            DataTable dataTable = new DataTable();
            string procedimiento = "TraerTipoPago";

            try
            {
                conexion = conexionMysql.AbrirConexion();

                MySqlCommand comando = new MySqlCommand(procedimiento, conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@p_IdPersona", IdPersona);

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(comando);
                dataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (conexion != null)
                {
                    conexionMysql.CerrarConexion(conexion);
                }
            }

            return dataTable;
        }

        public void InsertarCuotaYPago(int idPersona, DateTime fechaVencimiento, int fkTipo, DateTime fechaPago)
        {
            MySqlConnection conexion = null;
            string procedimiento = "InsertarCuotaYPago";

            try
            {
                conexion = conexionMysql.AbrirConexion();

                MySqlCommand comando = new MySqlCommand(procedimiento, conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@p_IdPersona", idPersona);
                comando.Parameters.AddWithValue("@p_FechaVencimiento", fechaVencimiento);
                comando.Parameters.AddWithValue("@p_FkTipo", fkTipo);
                comando.Parameters.AddWithValue("@p_FechaPago", fechaPago);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (conexion != null)
                {
                    conexionMysql.CerrarConexion(conexion);
                }
            }
        }

        public DataTable ListadoSociosFechaVencimiento(DateTime fechaInicio, DateTime fechaFin)
        {
            MySqlConnection conexion = null;
            DataTable dataTable = new DataTable();
            string procedimiento = "ListadoSociosFechaVencimiento";

            try
            {
                conexion = conexionMysql.AbrirConexion();

                MySqlCommand comando = new MySqlCommand(procedimiento, conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@p_FechaInicio", fechaInicio.ToString("yyyy-MM-dd"));
                comando.Parameters.AddWithValue("@p_FechaFin", fechaFin.ToString("yyyy-MM-dd"));

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(comando);
                dataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (conexion != null)
                {
                    conexionMysql.CerrarConexion(conexion);
                }
            }

            return dataTable;
        }
    }
}
