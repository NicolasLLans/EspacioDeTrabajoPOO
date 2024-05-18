using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

//se agrega paquetes para generar PDF
using iTextSharp.text;
using CentroDeportivo1E.Helpers;
using CentroDeportivo1E.Models;
using iTextSharp.text.pdf;
using System.Diagnostics;



namespace CentroDeportivo1E.Services
{
    internal class SocioService
    {
        SocioHelper socioHelper = new SocioHelper();


        public Socio BuscarSocio(string nombre, string apellido)
        {

            string rutaArchivo = socioHelper.ObtenerRutaArchivoJson();

            // Verificar si el archivo existe
            if (File.Exists(rutaArchivo))
            {
                string json = File.ReadAllText(rutaArchivo);
                List<Socio> socios = JsonSerializer.Deserialize<List<Socio>>(json);

                Socio socio = socios.FirstOrDefault(e => e.Nombre == nombre && e.Apellido == apellido);

                return socio;
            }
            else
            {
                return null;
            }
        }


        public List<Socio> ObtenerTodosLosSocios()
        {
            string rutaArchivo = socioHelper.ObtenerRutaArchivoJson();

            // Verificar si el archivo existe
            if (File.Exists(rutaArchivo))
            {
                string json = File.ReadAllText(rutaArchivo);
                List<Socio> socios = JsonSerializer.Deserialize<List<Socio>>(json);
                return socios;
            }
            else
            {
                return new List<Socio>();
            }
        }

        public List<Socio> ObtenerSociosPorNombre(string nombre)
        {
            string rutaArchivo = socioHelper.ObtenerRutaArchivoJson();
            List<Socio> sociosEncontrados = new List<Socio>();
           
            if (File.Exists(rutaArchivo))
            {
                string json = File.ReadAllText(rutaArchivo);
                List<Socio> todosLosSocios = JsonSerializer.Deserialize<List<Socio>>(json);

                foreach (Socio socio in todosLosSocios)
                {
                   
                    if (socio.Nombre.ToLower().Contains(nombre.ToLower()))
                    {
                        sociosEncontrados.Add(socio);
                    }
                }
            }

            return sociosEncontrados;
        }

        public List<Socio> ObtenerSociosPorApellido(string apellido)
        {
            string rutaArchivo = socioHelper.ObtenerRutaArchivoJson();
            List<Socio> sociosEncontrados = new List<Socio>();

            if (File.Exists(rutaArchivo))
            {
                string json = File.ReadAllText(rutaArchivo);
                List<Socio> todosLosSocios = JsonSerializer.Deserialize<List<Socio>>(json);

                foreach (Socio socio in todosLosSocios)
                {

                    if (socio.Apellido.ToLower().Contains(apellido.ToLower()))
                    {
                        sociosEncontrados.Add(socio);
                    }
                }
            }

            return sociosEncontrados;
        }

        public List<Socio> ObtenerSociosPorNombreApellido(string nombre,string apellido)
        {
            string rutaArchivo = socioHelper.ObtenerRutaArchivoJson();
            List<Socio> sociosEncontrados = new List<Socio>();

            if (File.Exists(rutaArchivo))
            {
                string json = File.ReadAllText(rutaArchivo);
                List<Socio> todosLosSocios = JsonSerializer.Deserialize<List<Socio>>(json);

                foreach (Socio socio in todosLosSocios)
                {

                    if (socio.Nombre.ToLower().Contains(nombre.ToLower())&& socio.Apellido.ToLower().Contains(apellido.ToLower()))
                    {
                        sociosEncontrados.Add(socio);
                    }
                }
            }

            return sociosEncontrados;
        }


        public void AltaSocio(Socio socio)

        {
            string rutaArchivo = socioHelper.ObtenerRutaArchivoJson();

            List<Socio> socios;

            // Verificar si el archivo ya existe
            if (File.Exists(rutaArchivo))
            {
                string json = File.ReadAllText(rutaArchivo);
                socios = JsonSerializer.Deserialize<List<Socio>>(json);
            }
            else
            {
                // crea una nueva lista de empleados si no existe una 
                socios = new List<Socio>();
            }

            socios.Add(socio);

            string jsonString = JsonSerializer.Serialize(socios);

            // guarda el JSON en el archivo
            File.WriteAllText(rutaArchivo, jsonString);
        }

        public long ObtenerUltimoNumeroSocio()
        {
            string rutaArchivo = socioHelper.ObtenerRutaArchivoJson();

            // Verificar si el archivo existe
            if (File.Exists(rutaArchivo))
            {
                string json = File.ReadAllText(rutaArchivo);
                List<Socio> socios = JsonSerializer.Deserialize<List<Socio>>(json);
                
                if (socios != null && socios.Any())
                {
                    long ultimoNumeroSocio = socios.Max(socio => socio.NumeroSocio);
                    return ultimoNumeroSocio;
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

    }
}
