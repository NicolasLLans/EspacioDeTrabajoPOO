using MySql.Data.MySqlClient;
using System.Data;

namespace CentroDeportivo1E.Services
{
    internal class PagosService
    {
        private readonly ConexionMysql conexionMysql = ConexionMysql.getInstance();

        public DataTable ListadoPagos(int IdPersona)
        {
            DataTable dataTable = new DataTable();
            string procedimiento = "ListadoPagos";

            try
            {
                MySqlConnection conexion = conexionMysql.AbrirConexion();

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
                conexionMysql.CerrarConexion();
            }

            return dataTable;
        }

        public DataTable TraerTipoPago(int IdPersona)
        {
            DataTable dataTable = new DataTable();
            string procedimiento = "TraerTipoPago";

            try
            {
                MySqlConnection conexion = conexionMysql.AbrirConexion();

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
                conexionMysql.CerrarConexion();
            }

            return dataTable;
        }

        public void InsertarCuotaYPago(int idPersona, DateTime fechaVencimiento, int fkTipo, DateTime fechaPago)
        {
            try
            {
                MySqlConnection conexion = conexionMysql.AbrirConexion();
                string procedimiento = "InsertarCuotaYPago";

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
                conexionMysql.CerrarConexion();
            }
        }

        public DataTable ListadoSociosFechaVencimiento(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable dataTable = new DataTable();

            try
            {
                MySqlConnection conexion = conexionMysql.AbrirConexion();
                string procedimiento = "ListadoSociosFechaVencimiento";

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
                conexionMysql.CerrarConexion();
            }

            return dataTable;
        }
    }
}
