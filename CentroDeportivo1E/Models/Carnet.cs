using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeportivo1E.Models
{
    internal class Carnet
    {
        public long CarnetID { get; set; }

        [ForeignKey("Socio")]
        public int Fk_NumeroSocio { get; set; }
        public DateTime Vencimiento { get; set; }

        public Socio Socio { get; set; }

    }
}
