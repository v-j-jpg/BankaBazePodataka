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
    
    public partial class Jemac
    {
        public int JMBG_JEM { get; set; }
        public string IME_JEM { get; set; }
        public string PRZ_JEM { get; set; }
        public string PLT_JEM { get; set; }
    
        public virtual Kes_kredit Kes_kredit { get; set; }
    }
}
