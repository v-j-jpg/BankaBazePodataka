//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankaBP2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zirant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zirant()
        {
            this.Klijents = new HashSet<Klijent>();
        }
    
        public int ID_ZIR { get; set; }
        public string IME_ZIR { get; set; }
        public string PRZ_ZIR { get; set; }
        public Nullable<int> PLT_ZIR { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Klijent> Klijents { get; set; }
    }
}
