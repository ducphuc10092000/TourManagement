//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class NGUOIDUNG
    {
        public int IDND { get; set; }
        public int IDNV { get; set; }
        public string USERNAME { get; set; }
        public string PASS { get; set; }
        public Nullable<bool> ACTIVE { get; set; }
    
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
