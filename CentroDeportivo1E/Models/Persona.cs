using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeportivo1E.Models
{
    internal class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long Telefono { get; set; }
        public int NumeroSocio { get; set; }
        public bool EstadoPago { get; set;}

        public Persona() { }

        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Nombre}, Apellido: {Apellido}, Teléfono: {Telefono}, Número de Socio: {NumeroSocio}, Estado de Pago: {(EstadoPago ? "Pagado" : "Pendiente")}";

        }
    }
}
