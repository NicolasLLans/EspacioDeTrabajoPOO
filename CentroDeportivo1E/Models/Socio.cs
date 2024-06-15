
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CentroDeportivo1E.Models
{
    internal class Socio : Persona
    {
        public int NumeroSocio { get; set; }
        public bool Activo { get; set; }
        public decimal CuotaMensual { get; set; }

        [ForeignKey("Persona")]
        public int FkPersona { get; set; }

        public Persona Persona { get; set; }

    }
}



