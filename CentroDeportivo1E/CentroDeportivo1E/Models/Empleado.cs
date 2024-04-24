using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeportivo1E.Models
{
    internal class Empleado:Persona
    {
        public new int Id { get; set; } 
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }
        public bool baja { get; set; } 

        // Constructor Vacio
        public Empleado()
        {
           
        }

        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Nombre}, Apellido: {Apellido}, Teléfono: {Telefono}, Número de Socio: {NumeroSocio}, Estado de Pago: {(EstadoPago ? "Pagado" : "Pendiente")}, Usuario: {Usuario}, Fecha de Alta: {FechaAlta}, Fecha de Baja: {FechaBaja}, Baja: {(baja ? "Sí" : "No")}"; // Cambiado a minúscula
        }
    }
}
