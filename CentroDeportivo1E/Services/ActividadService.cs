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
            else
            {
                // Si el archivo no existe, puedes devolver un valor predeterminado o null
                return null;
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
    // Verificar si la actividad existe
    Actividad actividad = ObtenerActividadesPorNombre(nombreActividad);
    if (actividad == null)
    {
        return "ACTIVIDAD INEXISTENTE";
    }

    // Verificar si el socio existe
    Socio socio = socioService.ObtenerSociosPorId(idSocio);
    if (socio == null)
    {
        return "SOCIO INEXISTENTE";
    }

    // Verificar que el socio no tenga más de 3 actividades permitidas
    if (socio.Actividades != null && socio.Actividades.Any() && socioService.ContarActividadesDelSocioPorNumero(idSocio) >= 3)
    {
        return "TOPE DE ACTIVIDADES ALCANZADO";
    }

    // Verificar si el socio ya está inscrito en la actividad
    if (socio.Actividades != null && socio.Actividades.Any(a => a.Nombre == nombreActividad))
    {
        return "El socio ya está inscrito en esta actividad";
    }

    // Agregar la actividad al socio
    if (socio.Actividades == null)
    {
        socio.Actividades = new List<Actividad>();
    }
    socio.Actividades.Add(actividad); // Agregar la actividad encontrada por nombre

    // Guardar los cambios en el archivo JSON
    socioService.ActualizarSocioEnArchivo(socio);

    return "El socio ha sido inscrito en la actividad exitosamente.";
}




    }
}
