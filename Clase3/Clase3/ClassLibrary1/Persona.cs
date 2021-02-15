using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [Table("tbPersona")]
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int edad { get; set; }
        public int IdTipoDoc { get; set; }
        public TipoDocumento TipoDocumento { get; set; } // para la relacion con TipoDocumento: DNI
    }
}
