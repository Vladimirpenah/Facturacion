﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SysFacturacion.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbfacturacionEntities : DbContext
    {
        public dbfacturacionEntities()
            : base("name=dbfacturacionEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<articulo> articuloes { get; set; }
        public virtual DbSet<cliente> clientes { get; set; }
        public virtual DbSet<empleado> empleadoes { get; set; }
    }
}