using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstYA
{
    [Table("Cliente")]
    public class Cliente
    {   
        [Key]
        [Required]
        public int idCliente { get; set; }
        [StringLength(50)]
        public string nombreCliente { get; set; }
        [StringLength(50)]
        public string apellidoCliente { get; set; }
        [Required]
        public DateTime fechaNacimiento { get; set; }
        [StringLength(15)]
        public string dniCliente { get; set; }

        public List<Tarjeta> tarjetas { get; set; }
    }
}
