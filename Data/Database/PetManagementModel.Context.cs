﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Model.Models;
    
    public partial class PetManagementEntities : DbContext
    {
        public PetManagementEntities()
            : base("name=PetManagementEntities")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Diet> Diets { get; set; }
        public virtual DbSet<Pet> Pets { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<AdminUser> AdminUsers { get; set; }
    }
}
