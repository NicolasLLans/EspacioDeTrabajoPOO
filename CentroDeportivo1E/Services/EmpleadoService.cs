using CentroDeportivo1E.Models;
using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace CentroDeportivo1E.Services
{
    internal class EmpleadoService
    {
        private readonly ConexionMysql conexionMysql;

        // Constructor que recibe las credenciales de conexión
        public EmpleadoService(string servidor, string puerto, string baseDatos, string usuario, string contrasena)
        {
            this.conexionMysql = new ConexionMysql(servidor, puerto, baseDatos, usuario, contrasena);
        }

        public Empleado BuscarUsuarioInicioSesion(string usuario, string contrasena)
        {
            Empleado empleado = null;
            MySqlConnection conexion = conexionMysql.AbrirConexion();

            try
            {
                using (conexion)
                {
                    string procedimiento = "BuscarUsuarioInicioSesion";

                    MySqlCommand comando = new MySqlCommand(procedimiento, conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@p_usuario", usuario);
                    comando.Parameters.AddWithValue("@p_contrasena", contrasena);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            empleado = new Empleado
                            {
                                Usuario = reader.GetString("Usuario"),
                                Contrasena = reader.GetString("Contrasena"),
                                Nombre = reader.GetString("Nombre"),
                                Apellido = reader.GetString("Apellido")
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar usuario: " + ex.Message);
            }
            finally
            {
                conexionMysql.CerrarConexion(conexion);
            }

            return empleado;
        }

        public void InsertarEmpleado(Empleado empleado)
        {
            MySqlConnection conexion = null;
            try
            {
                conexion = conexionMysql.AbrirConexion();
                string procedimiento = "InsertarEmpleado";

                using (MySqlCommand comando = new MySqlCommand(procedimiento, conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    // Asignar valores de Empleado a los parámetros del procedimiento almacenado
                    comando.Parameters.AddWithValue("@p_usuario", empleado.Usuario);
                    comando.Parameters.AddWithValue("@p_contrasena", empleado.Contrasena);
                    comando.Parameters.AddWithValue("@p_nombre", empleado.Nombre);
                    comando.Parameters.AddWithValue("@p_apellido", empleado.Apellido);
                    comando.Parameters.AddWithValue("@p_dni", empleado.Dni);
                    comando.Parameters.AddWithValue("@p_direccion", empleado.Direccion);
                    comando.Parameters.AddWithValue("@p_telefono", empleado.Telefono);
                    comando.Parameters.AddWithValue("@p_email", empleado.Email);
                    comando.Parameters.AddWithValue("@p_fechaAlta", empleado.FechaAlta);
                    comando.Parameters.AddWithValue("@p_puesto", empleado.Puesto);

                    comando.ExecuteNonQuery();
                }

                Console.WriteLine("Empleado insertado correctamente.");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al insertar empleado: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general al insertar empleado: " + ex.Message);
            }
            finally
            {
                conexionMysql.CerrarConexion(conexion);
            }
        }

        public bool ExisteUsuario(string usuario)
        {
            MySqlConnection conexion = conexionMysql.AbrirConexion();
            try
            {
                string procedimiento = "BuscarUsuario";

                using (MySqlCommand comando = new MySqlCommand(procedimiento, conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@p_usuario", usuario);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar usuario: " + ex.Message);
            }
            finally
            {
                conexionMysql.CerrarConexion(conexion);
            }

            return false;
        }
    }
}
