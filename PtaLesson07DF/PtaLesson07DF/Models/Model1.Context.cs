﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PtaLesson07DF.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PtaLesson07DFEntities : DbContext
    {
        public PtaLesson07DFEntities()
            : base("name=PtaLesson07DFEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<PtaKhoa> PtaKhoas { get; set; }
        public virtual DbSet<PtaSinhVien> PtaSinhViens { get; set; }
    }
}