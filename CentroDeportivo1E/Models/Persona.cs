namespace CentroDeportivo1E.Models
{
    internal class Persona
    {
        public int IdPersona { get; set; }
        public long Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public long Telefono { get; set; }
        public string Email { get; set; }
        public bool AptoFisico { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }
        public bool Baja { get; set; }

    }
}
