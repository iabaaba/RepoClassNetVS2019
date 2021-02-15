using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioVenta
{
    public class tbVenta
    {
        [Key]
        public int IdVenta { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdCliente { get; set; }

        public List<tbDetalleVenta> tbDetalleVenta { get; set; }
    }
}
