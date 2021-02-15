using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioVenta
{
    public class AppContext : DbContext 
    {
        public AppContext() : base("connBD")
        {
        }
        public DbSet<tbVenta>  tbVenta { get; set; }
        public DbSet<tbDetalleVenta> TbDetalleVentas { get; set; }
    }
}
