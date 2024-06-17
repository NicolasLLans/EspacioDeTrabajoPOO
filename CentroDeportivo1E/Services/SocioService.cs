using CentroDeportivo1E.Models;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace CentroDeportivo1E.Services
{
    internal class SocioService
    {
        private readonly ConexionMysql conexionMysql;

        // Constructor que recibe las credenciales de conexión
        public SocioService(string servidor, string puerto, string baseDatos, string usuario, string contrasena)
        {
            this.conexionMysql = new ConexionMysql(servidor, puerto, baseDatos, usuario, contrasena);
        }

        public void InsertarSocio(Socio socio)
        {
            MySqlConnection conexion = null;
            try
            {
                conexion = conexionMysql.AbrirConexion();
                string procedimiento = "InsertarSocio";

                using (conexion)
                {
                    MySqlCommand comando = new MySqlCommand(procedimiento, conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@p_nombre", socio.Nombre);
                    comando.Parameters.AddWithValue("@p_apellido", socio.Apellido);
                    comando.Parameters.AddWithValue("@p_dni", socio.Dni);
                    comando.Parameters.AddWithValue("@p_direccion", socio.Direccion);
                    comando.Parameters.AddWithValue("@p_telefono", socio.Telefono);
                    comando.Parameters.AddWithValue("@p_email", socio.Email);
                    comando.Parameters.AddWithValue("@p_fechaAlta", socio.FechaAlta);
                    comando.Parameters.AddWithValue("@p_aptoFisico", socio.AptoFisico);

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
                conexionMysql.CerrarConexion(conexion);
            }
        }

        public bool ExisteSocio(long dni)
        {
            bool existe = false;
            MySqlConnection conexion = null;

            try
            {
                conexion = conexionMysql.AbrirConexion();
                string procedimiento = "ExisteSocio";

                using (conexion)
                {
                    MySqlCommand comando = new MySqlCommand(procedimiento, conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@p_dni", dni);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            existe = reader.GetInt32(0) > 0;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al verificar existencia de socio: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general al verificar existencia de socio: " + ex.Message);
            }
            finally
            {
                conexionMysql.CerrarConexion(conexion);
            }

            return existe;
        }

        public DataTable TraerSocioPorDni(long dni)
        {
            MySqlConnection conexion = null;
            DataTable dataTable = new DataTable();

            try
            {
                conexion = conexionMysql.AbrirConexion();
                string procedimiento = "TraerSocioPorDni";

                using (conexion)
                {
                    MySqlCommand comando = new MySqlCommand(procedimiento, conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@p_Dni", dni);

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(comando);
                    dataAdapter.Fill(dataTable);
                }
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

        public DataTable TraerSociosActivos()
        {
            MySqlConnection conexion = null;
            DataTable dataTable = new DataTable();
            string procedimiento = "TraerSociosActivos";

            try
            {
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
                if (conexion != null)
                {
                    conexionMysql.CerrarConexion(conexion);
                }
            }

            return dataTable;
        }

        public void InsertarSocioActividad(int idSocio, int idActividad)
        {
            MySqlConnection conexion = null;
            try
            {
                conexion = conexionMysql.AbrirConexion();
                string procedimiento = "InsertarSocioActividad";

                using (conexion)
                {
                    MySqlCommand comando = new MySqlCommand(procedimiento, conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@p_IdSocio", idSocio);
                    comando.Parameters.AddWithValue("@p_IdActividad", idActividad);

                    comando.ExecuteNonQuery();
                }

                Console.WriteLine("Socio_Actividad cargado correctamente.");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al cargar socio_actividad: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general al nuevo socio_actividad: " + ex.Message);
            }
            finally
            {
                conexionMysql.CerrarConexion(conexion);
            }
        }

        public int VerificarLimiteActividades(int idSocio)
        {
            MySqlConnection conexion = null;
            int numeroActividades = 0;

            try
            {
                conexion = conexionMysql.AbrirConexion();
                string procedimiento = "VerificarLimiteActividades";

                using (conexion)
                {
                    MySqlCommand comando = new MySqlCommand(procedimiento, conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@p_IdSocio", idSocio);

                    MySqlParameter parametroSalida = new MySqlParameter("@p_NumeroActividades", MySqlDbType.Int32);
                    parametroSalida.Direction = ParameterDirection.Output;
                    comando.Parameters.Add(parametroSalida);

                    comando.ExecuteNonQuery();

                    numeroActividades = Convert.ToInt32(comando.Parameters["@p_NumeroActividades"].Value);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al verificar límite de actividades del socio: " + ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general al verificar límite de actividades del socio: " + ex.Message);
                throw;
            }
            finally
            {
                conexionMysql.CerrarConexion(conexion);
            }

            return numeroActividades;
        }

        public bool VerificarInscripcionExistente(int idSocio, int idActividad)
        {
            MySqlConnection conexion = null;
            bool existeInscripcion = false;

            try
            {
                conexion = conexionMysql.AbrirConexion();
                string procedimiento = "VerificarActividadSocio";

                using (conexion)
                {
                    MySqlCommand comando = new MySqlCommand(procedimiento, conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@p_IdSocio", idSocio);
                    comando.Parameters.AddWithValue("@p_IdActividad", idActividad);

                    MySqlParameter parametroSalida = new MySqlParameter("@p_ExisteInscripcion", MySqlDbType.Bit);
                    parametroSalida.Direction = ParameterDirection.Output;
                    comando.Parameters.Add(parametroSalida);

                    comando.ExecuteNonQuery();

                    existeInscripcion = Convert.ToBoolean(comando.Parameters["@p_ExisteInscripcion"].Value);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al verificar inscripción existente: " + ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general al verificar inscripción existente: " + ex.Message);
                throw;
            }
            finally
            {
                conexionMysql.CerrarConexion(conexion);
            }

            return existeInscripcion;
        }

        public DataTable TraerActividadPorNumeroSocio(int NumeroSocio)
        {
            MySqlConnection conexion = null;
            DataTable dataTable = new DataTable();
            string procedimiento = "TraerActividadesPorNumeroSocio";

            try
            {
                conexion = conexionMysql.AbrirConexion();

                MySqlCommand comando = new MySqlCommand(procedimiento, conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@p_NumeroSocio", NumeroSocio);

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

        public DataTable TraerListadoSociosYNoSocios()
        {
            MySqlConnection conexion = null;
            DataTable dataTable = new DataTable();
            string procedimiento = "ListadoSociosYNoSocios";

            try
            {
                conexion = conexionMysql.AbrirConexion();

                MySqlCommand comando = new MySqlCommand(procedimiento, conexion);
                comando.CommandType = CommandType.StoredProcedure;

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
