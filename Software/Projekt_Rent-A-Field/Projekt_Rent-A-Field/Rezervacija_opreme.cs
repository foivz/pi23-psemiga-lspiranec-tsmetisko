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
    
    public partial class Rezervacija_opreme
    {
        public int rezervacija_sportske_opreme_id { get; set; }
        public Nullable<int> sportska_oprema_id { get; set; }
        public Nullable<int> korisnik_id { get; set; }
        public Nullable<System.DateTime> datum { get; set; }
        public string vrijeme_od { get; set; }
        public Nullable<int> duljina_rezervacije { get; set; }
        public Nullable<int> placeno { get; set; }
        public Nullable<double> cijena { get; set; }
    
        public virtual Korisnik Korisnik { get; set; }
        public virtual Sportska_oprema Sportska_oprema { get; set; }
    }
}