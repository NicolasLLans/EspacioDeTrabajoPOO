using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CentroDeportivo1E.Helpers
{
    internal class EmpleadoHelper
    {

        //metodo para obtener carpeta y ruta de archivo json para empleado
        internal string ObtenerRutaArchivoJson()
        {
           
            string carpetaJson = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ArchivosJSON");
            string rutaArchivo = Path.Combine(carpetaJson, "empleados.json");

            if (!Directory.Exists(carpetaJson))
            {
                Directory.CreateDirectory(carpetaJson);
            }

            return rutaArchivo;
        }


        //metodo para encriptarContraseña
        internal string encriptarContrasena(string contrasena)
        {
            using (SHA256 encriptar = SHA256.Create())
            {
                byte[] bytes = encriptar.ComputeHash(Encoding.UTF8.GetBytes(contrasena));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }

        }
    }
}
