using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeportivo1E.Models
{
    internal class Cuota
    {
        public long IdCuota { get; set; }

        [ForeignKey("Persona")]
        public int FkPersona { get; set; }
           
        public DateTime FechaVencimiento { get; set; }
    
    }
}
