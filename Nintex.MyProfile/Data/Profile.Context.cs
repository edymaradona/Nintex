﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nintex.MyProfile.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NintextProfile : DbContext
    {
        public NintextProfile()
            : base("name=NintextProfile")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<PersonPermission> PersonPermissions { get; set; }
    }
}
