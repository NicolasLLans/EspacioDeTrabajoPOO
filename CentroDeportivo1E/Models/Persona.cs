namespace CentroDeportivo1E.Models
{
    internal class Persona
    {
       
        
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long Telefono { get; set; }
        public int NumeroSocio { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }


        // constructores
        public Persona(string nombre, string apellido, long telefono, string direccion, string email)
        {
           
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Direccion = direccion;
            Email = email;
        }

        public Persona()
        {
            
            Nombre = "";
            Apellido = "";
            Telefono = 0;
            Direccion = "";
            Email = "";
        }


        public override string ToString()
        {

            return $" Nombre: {Nombre}, Apellido: {Apellido}, Teléfono: {Telefono}, Número de Socio: {NumeroSocio}";

        }
    }
}
