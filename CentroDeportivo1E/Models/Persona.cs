namespace CentroDeportivo1E.Models
{
    internal class Persona
    {
        public static int UltimoId = 0;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public long Telefono { get; set; }
        public string Email { get; set; }
        public string Tipo { get; set; }

        // constructores
        public Persona(string nombre, string apellido, string direccion, long telefono, string email, string tipo)
        {
            Id = ++UltimoId;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Direccion = direccion;
            Email = email;
            Tipo = tipo;
        }

        public Persona()
        {
            Id = ++UltimoId;
            Nombre = "";
            Apellido = "";
            Telefono = 0;
            Direccion = "";
            Email = "";
            Tipo = "";
        }

        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Nombre}, Apellido: {Apellido}, Teléfono: {Telefono}, Direccion: {Direccion}, Email: {Email}";

        }
    }
}
