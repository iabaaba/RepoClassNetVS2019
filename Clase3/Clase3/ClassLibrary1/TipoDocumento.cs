﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [Table("tbTipoDocumento")]
    public class TipoDocumento
    
    {
        [Key]
        public int IdTipoDoc { get; set; }
        [Required]
        [StringLength(25)]
        public string NombreDocumento { get; set; }
        public List<Persona> Personas { get; set; }
    }
}
