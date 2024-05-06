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
using CentroDeportivo1E.Services;




namespace CentroDeportivo1E.Services
{
    internal class ActividadService
    {
        ActividadHelper actividadHelper = new ActividadHelper();
        SocioService socioService = new SocioService();

        public void GuardarActividad(Actividad actividad)

        {
            string rutaArchivo = actividadHelper.ObtenerRutaArchivoJson();

            List<Actividad> actividades;

            // Verificar si el archivo ya existe
            if (File.Exists(rutaArchivo))
            {
                string json = File.ReadAllText(rutaArchivo);
                actividades = JsonSerializer.Deserialize<List<Actividad>>(json);
            }
            else
            {
                // crea una nueva lista de empleados si no existe una 
                actividades = new List<Actividad>();
            }

            actividades.Add(actividad);

            string jsonString = JsonSerializer.Serialize(actividades);

            // guarda el JSON en el archivo
            File.WriteAllText(rutaArchivo, jsonString);
        }
        public Actividad BuscarActividad(string nombre)
        {

            string rutaArchivo = actividadHelper.ObtenerRutaArchivoJson();

            // Verificar si el archivo existe
            if (File.Exists(rutaArchivo))
            {
                string json = File.ReadAllText(rutaArchivo);
                List<Actividad> actividades = JsonSerializer.Deserialize<List<Actividad>>(json);

                Actividad actividad = actividades.FirstOrDefault(e => e.Nombre == nombre);

                return actividad;
            }
            else
            {
                return null;
            }
        }


        public List<Actividad> ObtenerTodasLasActividades()
        {
            string rutaArchivo = actividadHelper.ObtenerRutaArchivoJson();

            // Verificar si el archivo existe
            if (File.Exists(rutaArchivo))
            {
                string json = File.ReadAllText(rutaArchivo);
                List<Actividad> actividades = JsonSerializer.Deserialize<List<Actividad>>(json);
                return actividades;
            }
            else
            {
                return new List<Actividad>();
            }
        }

        public Actividad ObtenerActividadesPorNombre(string nombre)
        {
            string rutaArchivo = actividadHelper.ObtenerRutaArchivoJson();
            List<Actividad> actividadesEncontradas = new List<Actividad>();

            if (File.Exists(rutaArchivo))
            {
                string json = File.ReadAllText(rutaArchivo);
                List<Actividad> todasLasActividades = JsonSerializer.Deserialize<List<Actividad>>(json);

                Actividad actividad = todasLasActividades.FirstOrDefault(e => e.Nombre == nombre);
                return actividad;
            }

        }

       
        //se da de alta una actividad en el Club Deportivo
        public void AltaActividad(Actividad actividad)

        {
            string rutaArchivo = actividadHelper.ObtenerRutaArchivoJson();

            List<Actividad> actividades;

            // Verificar si el archivo ya existe
            if (File.Exists(rutaArchivo))
            {
                string json = File.ReadAllText(rutaArchivo);
                actividades = JsonSerializer.Deserialize<List<Actividad>>(json);
            }
            else
            {
                // crea una nueva lista de empleados si no existe una 
                actividades = new List<Actividad>();
            }

            actividades.Add(actividad);


            string jsonString = JsonSerializer.Serialize(actividades);

            // guarda el JSON en el archivo
            File.WriteAllText(rutaArchivo, jsonString);
        }

        public int ObtenerUltimoNumeroActividad()
        {
            string rutaArchivo = actividadHelper.ObtenerRutaArchivoJson();

            // Verificar si el archivo existe
            if (File.Exists(rutaArchivo))
            {
                string json = File.ReadAllText(rutaArchivo);
                List<Actividad> actividades = JsonSerializer.Deserialize<List<Actividad>>(json);

                if (actividades != null && actividades.Any())
                {
                    int ultimoNumeroActividad = actividades.Max(actividad => actividad.Id);
                    return ultimoNumeroActividad;
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

        //se da de alta a un socio en una actividad
        public string inscribirActividad(string nombreActividad, int idSocio)
        {

            // verifica si la actividad existe
            Actividad actividad = ObtenerActividadesPorNombre(nombreActividad);
            if (ObtenerActividadesPorNombre(nombreActividad) == null)
            {
                return "ACTIVIDAD INEXISTENTE";
            }

            // verifica si el socio existe 
            Socio socio = socioService.ObtenerSociosPorId(idSocio);

            if (socio == null)
            {
                return "SOCIO INEXISTENTE";
            }

            // verifica que el socio no tenga más de 3 actividades permitidas
            if (socioService.ContarActividadesDelSocioPorNumero(idSocio) >3)
            {
                return "TOPE DE ACTIVIDADES ALCANZADO";
            }


            
            // Agrega la actividad al socio
            socio.Actividades.Add(nombreActividad);

            // Actualiza los datos del socio en el archivo JSON o en tu fuente de datos
            socioService.ActualizarSocioEnArchivo(socio);

            // Reserva un lugar para el socio en la actividad
            Actividad actividad = BuscarActividad(nombreActividad);
             actividad.Inscritos.Add(idSocio);

                return "INSCRIPCIÓN EXITOSA";
            }
            else
            {
                return "ERROR AL INSCRIBIR AL SOCIO";
            }
        }
    }
}
