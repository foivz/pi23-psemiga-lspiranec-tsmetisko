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
    
    public partial class Rezultat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rezultat()
        {
            this.Rezervacija_prostora = new HashSet<Rezervacija_prostora>();
        }
    
        public int rezultat_id { get; set; }
        public string sport { get; set; }
        public string rezultat1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rezervacija_prostora> Rezervacija_prostora { get; set; }
    }
}