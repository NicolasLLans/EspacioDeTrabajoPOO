
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CentroDeportivo1E.Models
{
    internal class Socio : Persona
    {

        
        public new int NumeroSocio { get; set; }
        public bool Activo { get; set; }
        public decimal CuotaMensual { get; set; }
        public bool EstadoPago { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }
        public List<Actividad> Actividades { get; set; }

        public Socio(int numeroSocio, string nombre, string apellido, bool activo, decimal cuotaMensual, long telefono, bool estadoPago, string direccion, string email,
                       DateTime fechaAlta, DateTime fechaBaja)
                    : base(nombre, apellido, telefono, direccion, email)
        {
            NumeroSocio = numeroSocio;
            CuotaMensual = cuotaMensual;
            Activo = activo;
            EstadoPago = estadoPago;
            FechaAlta = fechaAlta;
            FechaBaja = fechaBaja;
            Actividades = new List<Actividad>(); 
        }

        public Socio()
        {
           
        }

        public override string ToString()
        {
            return $"Número de Socio: {NumeroSocio}\n" +
                   $"Nombre: {Nombre} {Apellido}\n" +
                   $"Teléfono: {Telefono}\n" +
                   $"Dirección: {Direccion}\n" +
                   $"Email: {Email}\n" +
                   $"Activo: {(Activo ? "Sí" : "No")}\n" +
                   $"Cuota Mensual: {CuotaMensual}\n" +
                   $"Estado de Pago: {(EstadoPago ? "Pagado" : "Pendiente")}\n" +
                   $"Fecha de Alta: {FechaAlta}\n" +
                   $"Fecha de Baja: {FechaBaja}";
        }

    }
}



