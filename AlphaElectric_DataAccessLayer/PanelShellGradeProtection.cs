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
    
    public partial class PanelShellGradeProtection
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PanelShellGradeProtection()
        {
            this.Panels = new HashSet<Panel>();
        }
    
        public int ID { get; set; }
        public string IPNum { get; set; }
        public string DescriptionSolids { get; set; }
        public string DescriptionLiquids { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Panel> Panels { get; set; }
    }
}
