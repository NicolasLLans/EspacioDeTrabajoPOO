using CentroDeportivo1E.Models;

namespace CentroDeportivo1E.Models
{
    internal class Socio : Persona
    {
        public int NumeroSocio { get; set; }
        public float CuotaMensual { get; set; }
        public bool Activo { get; set; }

        public Socio(string nombre, string apellido, string direccion, long telefono, string email, string tipo, int numeroSocio, float cuotaMensual, bool activo) : base(nombre, apellido, direccion, telefono, email, tipo)
        {
            NumeroSocio = numeroSocio;
            CuotaMensual = cuotaMensual;
            Activo = activo;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Nombre}, Apellido: {Apellido}, Teléfono: {Telefono}, NumeroSocio: {NumeroSocio}, Cuota mensual: {CuotaMensual}, Estado: {(Activo ? "Activo": "Impago")} ";
        }
    }
}
