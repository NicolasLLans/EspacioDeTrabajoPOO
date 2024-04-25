using CentroDeportivo1E.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeportivo1E.Services
{
    internal class EmpleadoService
    {
        public Empleado CrearEmpleado()
        {
            // Aquí puedes agregar lógica para crear el empleado.
            Empleado empleado = new Empleado()
            {
                Id = 1,
                Nombre = "Administrador",
                Apellido = "Centro Deportivo",
                Telefono = 08001231234,
                NumeroSocio = 00001,
                Usuario = "admin",
                Contrasena = "admin",
                FechaAlta = DateTime.ParseExact("24-04-2024", "dd-MM-yyyy", null)
            };
            return empleado;
        }
    }
}
