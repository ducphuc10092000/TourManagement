﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TourManagement.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TOURMANAGEMENTEntities : DbContext
    {
        public TOURMANAGEMENTEntities()
            : base("name=TOURMANAGEMENTEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CT_DIADIEM_TOUR> CT_DIADIEM_TOUR { get; set; }
        public virtual DbSet<CT_DOAN_BUAAN> CT_DOAN_BUAAN { get; set; }
        public virtual DbSet<CT_DOAN_CHIPHIKHAC> CT_DOAN_CHIPHIKHAC { get; set; }
        public virtual DbSet<CT_DOAN_KHACHHANG> CT_DOAN_KHACHHANG { get; set; }
        public virtual DbSet<CT_DOAN_KHACHSAN> CT_DOAN_KHACHSAN { get; set; }
        public virtual DbSet<CT_DOAN_NHANVIEN> CT_DOAN_NHANVIEN { get; set; }
        public virtual DbSet<CT_DOAN_PHUONGTIEN> CT_DOAN_PHUONGTIEN { get; set; }
        public virtual DbSet<DIADIEM> DIADIEM { get; set; }
        public virtual DbSet<DOAN> DOAN { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANG { get; set; }
        public virtual DbSet<KHACHSAN> KHACHSAN { get; set; }
        public virtual DbSet<NGUOIDUNG> NGUOIDUNG { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIEN { get; set; }
        public virtual DbSet<PHUONGTIEN> PHUONGTIEN { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TINHTHANH> TINHTHANH { get; set; }
        public virtual DbSet<TOUR> TOUR { get; set; }
    }
}
