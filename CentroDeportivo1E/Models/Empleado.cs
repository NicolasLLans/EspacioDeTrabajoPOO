using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeportivo1E.Models
{
    internal class Empleado : Persona
    {
        private static int ultimoId = 0;
        public  int Id { get; set; } 
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Puesto { get; set; }  
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }
        public bool baja { get; set; } // Cambiado a minúscula

        // Constructor Vacio
        public Empleado()
        {
            Id = ++ultimoId;
        }

        // Método ToString para representar la información del empleado como una cadena
        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Nombre}, Apellido: {Apellido}, Teléfono: {Telefono}, Número de Socio: {NumeroSocio}, Estado de Pago: {(EstadoPago ? "Pagado" : "Pendiente")}, Usuario: {Usuario}, Fecha de Alta: {FechaAlta}, Fecha de Baja: {FechaBaja}, Baja: {(baja ? "Sí" : "No")}"; // Cambiado a minúscula
        }
    }
}
