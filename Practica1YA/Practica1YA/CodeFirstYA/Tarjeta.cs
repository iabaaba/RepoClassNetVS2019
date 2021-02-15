using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstYA
{   [Table("Tarjeta")]
    public class Tarjeta
    {
        [Key]
        [Required]
        public int idTarjeta { get; set; }
        [StringLength(30)]
        public string numeroTarjeta { get; set; }
        [StringLength(20)]
        public string tipoTarjeta { get; set; }
        [StringLength(20)]
        public string modoPago { get; set; }
        public DateTime fechaVencimiento { get; set; }
        [Required]
        public int idCliente { get; set; }
        public Cliente cliente { get; set; }

        public List<Viaje> viajes { get; set; }
    }
}
