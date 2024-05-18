﻿using System;
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
                // Manejar excepciones específicas de MySQL
                Console.WriteLine("Error al cargar socio: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones
                Console.WriteLine("Error general al nuevo socio: " + ex.Message);
            }
            finally
            {
             
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
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
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return existe;
        }


    }
}
