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
    
    public partial class DIADIEM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIADIEM()
        {
            this.CT_DIADIEM_TOUR = new HashSet<CT_DIADIEM_TOUR>();
        }
    
        public int IDDIADIEM { get; set; }
        public string TENDIADIEM { get; set; }
        public string MOTA { get; set; }
        public Nullable<int> IDTT { get; set; }
        public string TINHTHANH { get; set; }
        public Nullable<bool> ACTIVE { get; set; }
        public string AVATAR { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_DIADIEM_TOUR> CT_DIADIEM_TOUR { get; set; }
        public virtual TINHTHANH TINHTHANH1 { get; set; }
    }
}
