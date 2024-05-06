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

        public Socio ObtenerSociosPorId(long numeroSocio)
        {
            string rutaArchivo = socioHelper.ObtenerRutaArchivoJson();

            if (File.Exists(rutaArchivo))
            {
                string json = File.ReadAllText(rutaArchivo);
                List<Socio> socios = JsonSerializer.Deserialize<List<Socio>>(json);

                Socio socio = socios.FirstOrDefault(e => e.NumeroSocio == numeroSocio);

                return socio; // Devolver directamente el socio encontrado
            }
            else
            {
                return null;
            }
        }
       
        public int ContarActividadesDelSocio(Socio socio)
        {
            if (socio != null && socio.Actividades != null)
            {
                return socio.Actividades.Count;
            }
            else
            {
                return 0;
            }
        }

        public int ContarActividadesDelSocioPorNumero(long numeroSocio)
        {
            Socio socio = ObtenerSociosPorId(numeroSocio);
            if (socio != null)
            {
                return ContarActividadesDelSocio(socio);
            }
            else
            {
                return -1;
            }
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

        public void ActualizarSocioEnArchivo(Socio socioActualizado)
        {
            if (socioActualizado == null)
            {
                throw new ArgumentNullException(nameof(socioActualizado), "El socio actualizado no puede ser nulo.");
            }

            string rutaArchivo = socioHelper.ObtenerRutaArchivoJson();

            // Verificar si el archivo existe
            if (File.Exists(rutaArchivo))
            {
                // Leer todos los socios del archivo JSON
                string json = File.ReadAllText(rutaArchivo);
                List<Socio> socios = JsonSerializer.Deserialize<List<Socio>>(json);

                // Buscar y actualizar el socio específico
                Socio socioExistente = socios.FirstOrDefault(s => s.NumeroSocio == socioActualizado.NumeroSocio);
                if (socioExistente != null)
                {              

                    // Agregar las actividades del socio actualizado al socio existente
                    socioExistente.Actividades = socioActualizado.Actividades;
                }

                // Convertir la lista de socios actualizada a formato JSON
                string jsonString = JsonSerializer.Serialize(socios);

                // Guardar el JSON actualizado en el archivo
                File.WriteAllText(rutaArchivo, jsonString);
            }
            else
            {
                throw new FileNotFoundException("No se pudo encontrar el archivo JSON de socios.", rutaArchivo);
            }
        }





    }
}
