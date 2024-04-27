using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeportivo1E.Models
{
    internal class Empleado : Persona


    {
        private int id;
        private string usuario;
        private string contrasena;
        private string puesto;
        private DateTime fechaAlta;
        private DateTime fechaBaja;
        private bool baja;

        private static int ultimoId = 0;


        public int Id
        {
            get { return id; }
            private set { id = value; }
        }
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }
        public string Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }
        public DateTime FechaAlta
        {
            get { return fechaAlta; }
            set { fechaAlta = value; }
        }
        public DateTime FechaBaja
        {
            get { return fechaBaja; }
            set { fechaBaja = value; }
        }
        public bool Baja
        {
            get { return baja; }
            set { baja = value; }
        }

        // Constructor Vacio
        public Empleado()
        {
            Id = ++ultimoId;
        }

        public Empleado(string nombre, string apellido, long telefono, int numeroSocio, bool estadoPago,
                string usuario, string contrasena, string puesto, DateTime fechaAlta, DateTime fechaBaja, bool baja)
                : base(nombre, apellido, telefono, numeroSocio, estadoPago)
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
            return $"ID: {Id}, Nombre: {Nombre}, Apellido: {Apellido}, Teléfono: {Telefono}, " +
                   $"Número de Socio: {NumeroSocio}, Estado de Pago: {(EstadoPago ? "Pagado" : "Pendiente")}, " +
                   $"Usuario: {Usuario}, Puesto: {Puesto}, Fecha de Alta: {FechaAlta}, Fecha de Baja: {FechaBaja}, " +
                   $"Baja: {(Baja ? "Sí" : "No")}";
        }



    }
}
