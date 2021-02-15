using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstYA
{
    [Table("Pais")]
    public class Pais
    {
        [Key]
        [Required]
        public int idPais { get; set; }
        [StringLength(50)]
        public string nombrePais { get; set; }
        [StringLength(50)]
        public string codigoPais { get; set; }
        public List<Viaje> Viajes { get; set; }

    }
}
