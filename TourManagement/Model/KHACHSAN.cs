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
    
    public partial class KHACHSAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHSAN()
        {
            this.CT_DOAN_KHACHSAN = new HashSet<CT_DOAN_KHACHSAN>();
        }
    
        public int IDKS { get; set; }
        public string DIACHI { get; set; }
        public string SDT { get; set; }
        public Nullable<int> IDTT { get; set; }
        public Nullable<bool> ACTIVE { get; set; }
        public string TINHTHANH { get; set; }
        public string TENKS { get; set; }
        public string MOTA { get; set; }
        public string AVATAR { get; set; }
        public string GIAKS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_DOAN_KHACHSAN> CT_DOAN_KHACHSAN { get; set; }
        public virtual TINHTHANH TINHTHANH1 { get; set; }
    }
}
