using MySql.Data.MySqlClient;
using System.Data;


namespace CentroDeportivo1E.Services
{
    internal class PagosService
    {
        private readonly ConexionMysql conexionMysql = new ConexionMysql();


        public DataTable ListadoPagos(int IdPersona)
        {
            MySqlConnection conexion = null;
            DataTable dataTable = new DataTable();
            string procedimiento = "ListadoPagos";

            try
            {
                conexion = conexionMysql.abrirConexion();

                MySqlCommand comando = new MySqlCommand(procedimiento, conexion);
                comando.CommandType = CommandType.StoredProcedure;

                // Agregar parámetro de entrada
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
                    conexionMysql.cerrarConexion(conexion);
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
                conexion = conexionMysql.abrirConexion();

                MySqlCommand comando = new MySqlCommand(procedimiento, conexion);
                comando.CommandType = CommandType.StoredProcedure;

                // Agregar parámetro de entrada
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
                    conexionMysql.cerrarConexion(conexion);
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
                conexion = conexionMysql.abrirConexion();

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
                    conexionMysql.cerrarConexion(conexion);
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
                conexion = conexionMysql.abrirConexion();

                MySqlCommand comando = new MySqlCommand(procedimiento, conexion);
                comando.CommandType = CommandType.StoredProcedure;

                // Convertir las fechas a formato 'yyyy-MM-dd'
                string fechaInicioStr = fechaInicio.ToString("yyyy-MM-dd");
                string fechaFinStr = fechaFin.ToString("yyyy-MM-dd");

                // Agregar parámetros de entrada
                comando.Parameters.AddWithValue("@p_FechaInicio", fechaInicioStr);
                comando.Parameters.AddWithValue("@p_FechaFin", fechaFinStr);

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
                    conexionMysql.cerrarConexion(conexion);
                }
            }

            return dataTable;
        }


    }
}
