using CentroDeportivo1E.Helpers;
using CentroDeportivo1E.Models;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace CentroDeportivo1E.Services
{
    internal class NoSocioService
    {
        private readonly ConexionMysql conexionMysql;

        // Constructor que recibe las credenciales de conexión
        public NoSocioService(string servidor, string puerto, string baseDatos, string usuario, string contrasena)
        {
            this.conexionMysql = new ConexionMysql(servidor, puerto, baseDatos, usuario, contrasena);
        }

        public void InsertarNoSocio(NoSocio noSocio)
        {
            MySqlConnection conexion = null;
            try
            {
                conexion = conexionMysql.AbrirConexion();
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
                conexionMysql.CerrarConexion(conexion);
            }
        }

        public bool ExisteNoSocio(long dni)
        {
            bool existe = false;
            MySqlConnection conexion = null;

            try
            {
                conexion = conexionMysql.AbrirConexion();
                string procedimiento = "ExisteNoSocio";

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
    }
}
