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
    
    public partial class IzdatiKrediti
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IzdatiKrediti()
        {
            this.Kredits = new HashSet<Kredit>();
        }
    
        public int KlijentJMBG_KLI { get; set; }
        public int SluzbenikJMBG_RAD { get; set; }
        public int OdobrenjeRISKID_KOMISIJE { get; set; }
        public int OdobrenjeOdlukaID_ODLUKE { get; set; }
    
        public virtual Klijent Klijent { get; set; }
        public virtual Sluzbenik Sluzbenik { get; set; }
        public virtual Odobrenje Odobrenje { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kredit> Kredits { get; set; }
    }
}
