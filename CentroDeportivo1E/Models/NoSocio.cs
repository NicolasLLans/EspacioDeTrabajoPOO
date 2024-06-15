using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeportivo1E.Models
{
    internal class NoSocio: Persona
    {

        public int NumeroNoSocio { get; set; }
        public decimal ValorPago { get; set; }

        [ForeignKey("Persona")]
        public int FkPersona { get; set; }

        public Persona Persona { get; set; }

    }
}
