using System.ComponentModel.DataAnnotations.Schema;

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
