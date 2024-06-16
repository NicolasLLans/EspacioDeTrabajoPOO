
using System.ComponentModel.DataAnnotations.Schema;

namespace CentroDeportivo1E.Models
{
    internal class Pago
    {
        public int IdPago { get; set; }

        [ForeignKey("Cuota")]
        public int FkCuota { get; set;}

        public DateTime FechaPago { get; set; }
    }
}
