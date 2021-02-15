using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ApplicationDBContext : DbContext
    {
        // DbContext sirve para configurar algunas de las caracteristicas que tendra la DB
        public ApplicationDBContext(): base("connBD")
        {
            //
        }
        // DBSet, esta propiedad permitira migrar de una clase a una tabla de DB 
        public DbSet<Persona> Persona { get; set; }
        public DbSet<TipoDocumento> TipoDocumento { get; set; }
    }
}
