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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Model1Container : DbContext
    {
        public Model1Container()
            : base("name=Model1Container")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Banka> Bankas { get; set; }
        public virtual DbSet<Filijala> Filijalas { get; set; }
        public virtual DbSet<Sluzbenik> Sluzbeniks { get; set; }
        public virtual DbSet<Klijent> Klijents { get; set; }
        public virtual DbSet<IzdatiKrediti> IzdatiKreditis { get; set; }
        public virtual DbSet<RISK> RISKs { get; set; }
        public virtual DbSet<Odluka> Odlukas { get; set; }
        public virtual DbSet<Odobrenje> Odobrenjes { get; set; }
        public virtual DbSet<Zirant> Zirants { get; set; }
        public virtual DbSet<Gazdnistvo> Gazdnistvoes { get; set; }
        public virtual DbSet<Kompanija> Kompanijas { get; set; }
        public virtual DbSet<Jemac> Jemacs { get; set; }
        public virtual DbSet<Kredit> Kredits { get; set; }
    }
}
