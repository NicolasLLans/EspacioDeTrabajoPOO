
using System.ComponentModel.DataAnnotations.Schema;

namespace CentroDeportivo1E.Models
{
    internal class Pago
    {
        public int IdPago { get; set; }

        [ForeignKey("Cuota")]
        public int FkCuota { get; set;}

        [ForeignKey("TipoPago")]
        public int fkTipo { get; set; }

        public DateTime FechaPago { get; set; }
    }
}
