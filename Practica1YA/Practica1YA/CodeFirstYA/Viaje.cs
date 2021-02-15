using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstYA
{   
    [Table("Viaje")]
    public class Viaje
    {
        [Key]
        [Required]
        public int idViaje { get; set; }
        [Required]
        public int idTarjeta { get; set; }
        [Required]
        public int idPais { get; set; }
        [Required]
        public DateTime fechaInicioViaje { get; set; }
        [Required]
        public DateTime fechaFinViaje { get; set; }
        [StringLength(1)]
        public string estadoViaje { get; set; }

        public Pais pais { get; set; }

        public Tarjeta tarjeta { get; set; }
    }
}
