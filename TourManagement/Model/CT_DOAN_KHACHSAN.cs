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
    
    public partial class CT_DOAN_KHACHSAN
    {
        public int IDCT { get; set; }
        public Nullable<int> IDDOAN { get; set; }
        public Nullable<int> IDKS { get; set; }
        public string CHIPHIKS { get; set; }
        public Nullable<int> SOPHONGDON { get; set; }
        public Nullable<int> SOPHONGDOI { get; set; }
        public Nullable<int> SONGAYO { get; set; }
    
        public virtual DOAN DOAN { get; set; }
        public virtual KHACHSAN KHACHSAN { get; set; }
    }
}
