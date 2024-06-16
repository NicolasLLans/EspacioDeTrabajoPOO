using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using iTextSharp.text;
using CentroDeportivo1E.Helpers;
using CentroDeportivo1E.Models;
using iTextSharp.text.pdf;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Data;



namespace CentroDeportivo1E.Services
{
    internal class SocioService
    {
        SocioHelper socioHelper = new SocioHelper();
        private readonly ConexionMysql conexionMysql = new ConexionMysql();


        public void InsertarSocio(Socio socio)
        {
            MySqlConnection conexion = null;
            try
            {
                conexion = conexionMysql.abrirConexion();
                string procedimiento = "InsertarSocio";

                using (conexion)
                {
                    MySqlCommand comando = new MySqlCommand(procedimiento, conexion);
               
                    comando.CommandType = CommandType.StoredProcedure;

                    // Asignar valores de Empleado a los parámetros del procedimiento almacenado
                   
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
                conexionMysql.cerrarConexion(conexion);
            }
        }

        public bool ExisteSocio(long dni)
        {
            bool existe = false;
            MySqlConnection conexion = null;

            try
            {
                conexion = conexionMysql.abrirConexion();
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
                conexionMysql.cerrarConexion(conexion);
            }

            return existe;
        }

        public DataTable TraerSocioPorDni(long dni)
        {
            
            MySqlConnection conexion = null;
            DataTable dataTable = new DataTable();

            try
            {
                conexion = conexionMysql.abrirConexion();
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
                    conexionMysql.cerrarConexion(conexion);
                }
            }

            return dataTable;
        }

        public DataTable traerSociosActivos()
        {
            MySqlConnection conexion = null;
            DataTable dataTable = new DataTable();
            string procedimiento = "TraerSociosActivos";

            try
            {
                conexion = conexionMysql.abrirConexion();

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
                    conexionMysql.cerrarConexion(conexion);
                }
            }

            return dataTable;
        }

        public void InsertarSocioActividad(int idSocio, int idActividad)
        {
            MySqlConnection conexion = null;
            try
            {
                conexion = conexionMysql.abrirConexion();
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
                conexionMysql.cerrarConexion(conexion);
            }
        }


        public int VerificarLimiteActividades(int idSocio)
        {
            MySqlConnection conexion = null;
            int numeroActividades = 0;

            try
            {
                conexion = conexionMysql.abrirConexion();
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
                conexionMysql.cerrarConexion(conexion);
            }

            return numeroActividades;
        }

        public bool VerificarInscripcionExistente(int idSocio, int idActividad)
        {
            MySqlConnection conexion = null;
            bool existeInscripcion = false;

            try
            {
                conexion = conexionMysql.abrirConexion();
                string procedimiento = "VerificarActividadSocio";

                using (conexion)
                {
                    MySqlCommand comando = new MySqlCommand(procedimiento, conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    // entrada
                    comando.Parameters.AddWithValue("@p_IdSocio", idSocio);
                    comando.Parameters.AddWithValue("@p_IdActividad", idActividad);

                    // salida
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
                conexionMysql.cerrarConexion(conexion);
            }

            return existeInscripcion;
        }


        public DataTable traerActividadPorNumeroSocio(int NumeroSocio)
        {
            MySqlConnection conexion = null;
            DataTable dataTable = new DataTable();
            string procedimiento = "TraerActividadesPorNumeroSocio";

            try
            {
                conexion = conexionMysql.abrirConexion();

                MySqlCommand comando = new MySqlCommand(procedimiento, conexion);
                comando.CommandType = CommandType.StoredProcedure;

                // Agregar parámetro de entrada
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
                    conexionMysql.cerrarConexion(conexion);
                }
            }

            return dataTable;
        }





    }
}
