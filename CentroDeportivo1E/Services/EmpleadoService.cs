using CentroDeportivo1E.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using CentroDeportivo1E.Helpers;
using MySql.Data.MySqlClient;

namespace CentroDeportivo1E.Services
{
    internal class EmpleadoService
    {
        private EmpleadoHelper empleadoHelpler = new EmpleadoHelper();


        private readonly ConexionMysql conexionMysql = new ConexionMysql();

        public Empleado BuscarUsuarioInicioSesion(string usuario, string contrasena)
        {
            Empleado empleado = null;

            try
            {
                using (MySqlConnection conexion = conexionMysql.abrirConexion())
                {
                    string consulta = @"SELECT e.*, p.* FROM Empleado as e 
                                        INNER JOIN Persona as p ON p.id = e.fkPersona 
                                        WHERE e.Usuario = @usuario AND e.Contrasena = @contrasena;";

                    MySqlCommand comando = new MySqlCommand(consulta, conexion);

                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@contrasena", contrasena);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            empleado = new Empleado
                            {
                                Id = reader.GetInt32("Id"),
                                Usuario = reader.GetString("Usuario"),
                                Contrasena = reader.GetString("Contrasena"),
                                Nombre = reader.GetString("Nombre"),
                                Apellido = reader.GetString("Apellido"),
                                Puesto = reader.GetString("Puesto"),
                                
                            };
                        }
                    }
                }
                conexionMysql.cerrarConexion(conexionMysql.abrirConexion());
            }
            catch (Exception ex)
            {
             
                Console.WriteLine("Error al buscar usuario: " + ex.Message);
            }

            return empleado;
        }
    



    public void GuardarEmpleado(Empleado empleado)

        {
            string rutaArchivo = empleadoHelpler.ObtenerRutaArchivoJson();

            List<Empleado> empleados;

            // Verificar si el archivo ya existe
            if (File.Exists(rutaArchivo))
            {
                string json = File.ReadAllText(rutaArchivo);
                empleados = JsonSerializer.Deserialize<List<Empleado>>(json);
            }
            else
            {
                // crea una nueva lista de empleados si no existe una 
                empleados = new List<Empleado>();
            }

            empleados.Add(empleado);

            string jsonString = JsonSerializer.Serialize(empleados);

            // guarda el JSON en el archivo
            File.WriteAllText(rutaArchivo, jsonString);
        }

        public int ObtenerUltimoId()
        {
            string rutaArchivo = empleadoHelpler.ObtenerRutaArchivoJson();

            // Verificar si el archivo existe
            if (File.Exists(rutaArchivo))
            {
                string json = File.ReadAllText(rutaArchivo);
                List<Empleado> empleados = JsonSerializer.Deserialize<List<Empleado>>(json);

                if (empleados != null && empleados.Any())
                {
                    int ultimoId = empleados.Max(empleado => empleado.Id);
                    return ultimoId;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }


        }

        public Empleado BuscarUsuario( string usuario)
        {
            string rutaArchivo = empleadoHelpler.ObtenerRutaArchivoJson();

            // Verificar si el archivo existe
            if (File.Exists(rutaArchivo))
            {
                string json = File.ReadAllText(rutaArchivo);
                List<Empleado> empleados = JsonSerializer.Deserialize<List<Empleado>>(json);

                Empleado empleado = empleados.FirstOrDefault(e => (e.Usuario == usuario));

                return empleado;
            }
            else
            {
                return null;
            }
        }


    }
}

