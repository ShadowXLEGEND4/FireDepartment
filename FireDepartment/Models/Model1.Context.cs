﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FireDepartment.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FireDepartmentEntities : DbContext
    {
        public FireDepartmentEntities()
            : base("name=FireDepartmentEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Accident> Accidents { get; set; }
        public virtual DbSet<Fireman> Firemans { get; set; }
        public virtual DbSet<Truck> Trucks { get; set; }
    }
}