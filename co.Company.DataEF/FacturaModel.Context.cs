﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace co.Company.DataEF
{
    using co.company.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FacturaConex : DbContext
    {
        public FacturaConex()
            : base("name=FacturaConex")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public object Entry()
        {
            throw new NotImplementedException();
        }

        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<FacturaDetalle> FacturaDetalle { get; set; }
        public virtual DbSet<FacturaEncabezado> FacturaEncabezado { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}
