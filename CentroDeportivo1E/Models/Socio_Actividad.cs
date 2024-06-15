using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeportivo1E.Models
{
    internal class Socio_Actividad
    {
        public int IdSocio { get; set; }
        public int IdActividad { get; set; }

        // Relación con la clase Socio
        [ForeignKey("IdSocio")]
        public Socio Socio { get; set; }

        // Relación con la clase Actividad
        [ForeignKey("IdActividad")]
        public Actividad Actividad { get; set; }
    }
}
