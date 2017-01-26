//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlphaElectric_DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Panel : Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Panel()
        {
            this.Panel_ProjectBT = new HashSet<Panel_ProjectBT>();
        }
    
        public int PanelShellGradeProtectionIPNumber { get; set; }
        public int SizeTypeID { get; set; }
        public int CertificationID { get; set; }
        public int TypeID { get; set; }
    
        public virtual PanelShellGradeProtection PanelShellGradeProtection { get; set; }
        public virtual SizeType SizeType { get; set; }
        public virtual Certification Certification { get; set; }
        public virtual Type Type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Panel_ProjectBT> Panel_ProjectBT { get; set; }
    }
}
