using System.ComponentModel.DataAnnotations.Schema;

namespace CentroDeportivo1E.Models
{
    internal class Empleado : Persona

    {
        public int IdEmpleado { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Puesto { get; set; }

        [ForeignKey("Persona")]
        public int FkPersona { get; set; }

        public Persona Persona { get; set; }

    }
}
