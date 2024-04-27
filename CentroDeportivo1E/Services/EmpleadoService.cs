using CentroDeportivo1E.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using CentroDeportivo1E.Helpers;

namespace CentroDeportivo1E.Services
{
    internal class EmpleadoService
    {
        private EmpleadoHelper empleadoHelpler = new EmpleadoHelper();


        public Empleado BuscarUsuarioInicioSesion(string usuario, string contrasena)
        {

            string rutaArchivo = empleadoHelpler.ObtenerRutaArchivoJson();

            // Verificar si el archivo existe
            if (File.Exists(rutaArchivo))
            {
              
                string json = File.ReadAllText(rutaArchivo);
                List<Empleado> empleados = JsonSerializer.Deserialize <List<Empleado>>(json);

                Empleado empleado = empleados.FirstOrDefault(e => e.Usuario == usuario && e.Contrasena == contrasena);

                return empleado;
            }
            else
            {
                MessageBox.Show("No se encontró el archivo de empleados. Por favor, contacte al administrador.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
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


    }
}

