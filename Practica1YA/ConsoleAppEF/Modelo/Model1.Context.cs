﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ConnectionDB : DbContext
    {
        public ConnectionDB()
            : base("name=ConnectionDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbCliente> tbCliente { get; set; }
        public virtual DbSet<tbPais> tbPais { get; set; }
        public virtual DbSet<tbTarjeta> tbTarjeta { get; set; }
        public virtual DbSet<tbViaje> tbViaje { get; set; }
    }
}
