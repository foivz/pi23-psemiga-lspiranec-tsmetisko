//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Trening_program
    {
        public int trening_program_id { get; set; }
        public Nullable<int> korisnik_id { get; set; }
        public string naziv { get; set; }
        public string opis { get; set; }
        public string tip_programa { get; set; }
    
        public virtual Korisnik Korisnik { get; set; }
    }
}
