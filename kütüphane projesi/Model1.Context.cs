﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kütüphane_projesi
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KutuphaneProjesiEntities2 : DbContext
    {
        public KutuphaneProjesiEntities2()
            : base("name=KutuphaneProjesiEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tbl_Emanet> tbl_Emanet { get; set; }
        public virtual DbSet<tbl_Uyeler> tbl_Uyeler { get; set; }
        public virtual DbSet<tbl_Kullanici> tbl_Kullanici { get; set; }
        public virtual DbSet<tbl_Kitap> tbl_Kitap { get; set; }
    }
}
