//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleAppEF.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbCliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbCliente()
        {
            this.tbTarjeta = new HashSet<tbTarjeta>();
        }
    
        public int idCliente { get; set; }
        public string nombreCliente { get; set; }
        public string apellidosCliente { get; set; }
        public System.DateTime fechaNacimiento { get; set; }
        public string dniCliente { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTarjeta> tbTarjeta { get; set; }
    }
}
