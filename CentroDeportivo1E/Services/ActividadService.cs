using System;
using System.Collections.Generic;
using System.Data;
using CentroDeportivo1E.Models;
using MySql.Data.MySqlClient;

namespace CentroDeportivo1E.Services
{
    internal class ActividadService
    {
        private readonly ConexionMysql conexionMysql;

        // Constructor que recibe las credenciales de conexión
        public ActividadService(string servidor, string puerto, string baseDatos, string usuario, string contrasena)
        {
            this.conexionMysql = new ConexionMysql(servidor, puerto, baseDatos, usuario, contrasena);
        }

        public void InsertarActividad(Actividad actividad)
        {
            MySqlConnection conexion = null;

            try
            {
                conexion = conexionMysql.AbrirConexion();
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
                conexionMysql.CerrarConexion(conexion);
            }
        }

        public DataTable TraerTodasActividades()
        {
            MySqlConnection conexion = null;
            DataTable dataTable = new DataTable();
            string procedimiento = "TraerActividadesActivas";

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
    }
}
