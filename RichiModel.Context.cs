﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Richi.Shop._1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RICHIJOBEntities : DbContext
    {
        public RICHIJOBEntities()
            : base("name=RICHIJOBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<RJ_ADMINISTRADORES> RJ_ADMINISTRADORES { get; set; }
        public virtual DbSet<RJ_AFILIADOS> RJ_AFILIADOS { get; set; }
        public virtual DbSet<RJ_CATEGORIAS> RJ_CATEGORIAS { get; set; }
        public virtual DbSet<RJ_PUESTOS> RJ_PUESTOS { get; set; }
    }
}
