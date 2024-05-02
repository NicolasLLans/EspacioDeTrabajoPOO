using CentroDeportivo1E.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeportivo1E.Models
{
    internal class ClubDeportivo
    {
        private List<Socio>? listaDeSocios;

        public void inscribirActividad(Socio socio, Actividad nuevaActividad)
        {
            int CantActividades = socio.Actividades.Count;
            Console.WriteLine($"El socio {socio.Nombre} tiene {CantActividades} actividades inscritas.");

            if (socio.Actividades.Count < 3)
            {
                socio.Actividades.Add(nuevaActividad);
                Console.WriteLine($"Se ha inscrito la actividad '{nuevaActividad.Nombre}' al socio {socio.Nombre}.");
            }
            else
            {
                Console.WriteLine($"El socio {socio.Nombre} ya tiene el máximo de actividades inscritas.");
            }
        }
    }
}
