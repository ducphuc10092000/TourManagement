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
    
    public partial class TOUR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TOUR()
        {
            this.CT_DIADIEM_TOUR = new HashSet<CT_DIADIEM_TOUR>();
        }
    
        public int IDTOUR { get; set; }
        public string TENTOUR { get; set; }
        public string GIATOUR { get; set; }
        public Nullable<bool> TINHTRANG { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_DIADIEM_TOUR> CT_DIADIEM_TOUR { get; set; }
    }
}
