using System;
using System.Collections.Generic;
using System.Data;
using CentroDeportivo1E.Models;
using MySql.Data.MySqlClient;

namespace CentroDeportivo1E.Services
{
    internal class ActividadService
    {
        private readonly ConexionMysql conexionMysql = new ConexionMysql();

        public void InsertarActividad(Actividad actividad)
        {
            MySqlConnection conexion = null;

            try
            {
                conexion = conexionMysql.abrirConexion();
                string procedimiento = "InsertarActividad";

                using (conexion)
                {
                    MySqlCommand comando = new MySqlCommand(procedimiento, conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@p_nombre", actividad.Nombre);
                    comando.Parameters.AddWithValue("@p_precio", actividad.Precio);

                    if (conexion.State != ConnectionState.Open) // Verificar si la conexión está cerrada
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
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexionMysql.cerrarConexion(conexion);
                }
            }
        }



    }
}
