using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace CentroDeportivo1E.Models
{
    internal class Persona
    {
        private static int ultimoId = 0;
        private int id;
        private string nombre;
        private string apellido;
        private long telefono;
        private int numeroSocio;
        private bool estadoPago;

        public int Id
        {
            get { return id; }
            private set { id = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public long Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public int NumeroSocio
        {
            get { return numeroSocio; }
            set { numeroSocio = value; }
        }

        public bool EstadoPago
        {
            get { return estadoPago; }
            set { estadoPago = value; }
        }

        // constructores
        public Persona(string nombre, string apellido, long telefono, int numeroSocio, bool estadoPago)
        {
            Id = ++ultimoId;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            NumeroSocio = numeroSocio;
            EstadoPago = estadoPago;
        }

        public Persona()
        {
            Id = ++ultimoId;
            Nombre = "";
            Apellido = "";
            Telefono = 0;
            NumeroSocio = 0;
            EstadoPago = false;
        }


        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Nombre}, Apellido: {Apellido}, Teléfono: {Telefono}, Número de Socio: {NumeroSocio}, Estado de Pago: {(EstadoPago ? "Pagado" : "Pendiente")}";
        }
    }
}
