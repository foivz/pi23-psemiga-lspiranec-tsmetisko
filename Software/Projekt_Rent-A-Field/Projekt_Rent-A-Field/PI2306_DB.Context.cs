﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projekt_Rent_A_Field
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PI2306_DBEntities : DbContext
    {
        public PI2306_DBEntities()
            : base("name=PI2306_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Dogadaj> Dogadajs { get; set; }
        public virtual DbSet<Korisnik> Korisniks { get; set; }
        public virtual DbSet<Povratna_informacija_obrazac> Povratna_informacija_obrazac { get; set; }
        public virtual DbSet<Prihvati_prigovor> Prihvati_prigovor { get; set; }
        public virtual DbSet<Rezervacija_opreme> Rezervacija_opreme { get; set; }
        public virtual DbSet<Rezervacija_prostora> Rezervacija_prostora { get; set; }
        public virtual DbSet<Rezervacija_trenera> Rezervacija_trenera { get; set; }
        public virtual DbSet<Rezultat> Rezultats { get; set; }
        public virtual DbSet<Sportska_oprema> Sportska_oprema { get; set; }
        public virtual DbSet<Sportski_prostor> Sportski_prostor { get; set; }
        public virtual DbSet<Trener> Treners { get; set; }
        public virtual DbSet<Trening_program> Trening_program { get; set; }
        public virtual DbSet<Uloga> Ulogas { get; set; }
    }
}