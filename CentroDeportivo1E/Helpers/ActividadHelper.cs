using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeportivo1E.Helpers
{
    internal class ActividadHelper
    {
        internal string ObtenerRutaArchivoJson()
        {

            string carpetaJson = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ArchivosJSON");
            string rutaArchivo = Path.Combine(carpetaJson, "Actividad.json");

            if (!Directory.Exists(carpetaJson))
            {
                Directory.CreateDirectory(carpetaJson);
            }

            return rutaArchivo;
        }
    }
}
