namespace CentroDeportivo1E.Models
{
    internal class Empleado : Persona

    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Puesto { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }
        public bool Baja { get; set; }
        

        private static int ultimoId = 0;

        // Constructor Vacio
        public Empleado()
        {
            Id = ++ultimoId;
        }
        public Empleado(string nombre, string apellido, string direccion, long telefono, string email,
                string usuario, string contrasena, string puesto, DateTime fechaAlta, DateTime fechaBaja, bool baja)
                : base(nombre, apellido, telefono,direccion, email)
        {
            Usuario = usuario;
            Contrasena = contrasena;
            Puesto = puesto;
            FechaAlta = fechaAlta;
            FechaBaja = fechaBaja;
            Baja = baja;
        }

        public override string ToString()
        {

            return $"ID: {Id}, Nombre: {Nombre}, Apellido: {Apellido}, Teléfono: {Telefono}, Direccion: {Direccion}, Email: {Email}, Usuario: {Usuario}, Puesto: {Puesto}, Fecha de Alta: {FechaAlta}, Fecha de Baja: {FechaBaja}" + $"Baja: {(Baja ? "Sí" : "No")}";
        }



    }
}
