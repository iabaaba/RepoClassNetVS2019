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
    
    public partial class tbViaje
    {
        public int idViaje { get; set; }
        public int idTarjeta { get; set; }
        public int idPais { get; set; }
        public System.DateTime fechaInicioViaje { get; set; }
        public System.DateTime fechaFinViaje { get; set; }
        public string estadoViaje { get; set; }
    
        public virtual tbPais tbPais { get; set; }
        public virtual tbTarjeta tbTarjeta { get; set; }
    }
}
