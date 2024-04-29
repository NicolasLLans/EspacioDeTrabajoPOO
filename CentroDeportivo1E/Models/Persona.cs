namespace CentroDeportivo1E.Models
{
    internal class Persona
    {
        private static int ultimoId = 0;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long Telefono { get; set; }
        public int NumeroSocio { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }


        // constructores
        public Persona(string nombre, string apellido, long telefono, string direccion, string email)
        {
            Id = ++ultimoId;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Direccion = direccion;
            Email = email;
        }

        public Persona()
        {
            Id = ++ultimoId;
            Nombre = "";
            Apellido = "";
            Telefono = 0;
            Direccion = "";
            Email = "";
        }


        public override string ToString()
        {

            return $"ID: {Id}, Nombre: {Nombre}, Apellido: {Apellido}, Teléfono: {Telefono}, Número de Socio: {NumeroSocio}";

        }
    }
}
