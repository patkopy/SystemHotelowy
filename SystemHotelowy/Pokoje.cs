//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SystemHotelowy
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pokoje
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pokoje()
        {
            this.Rezerwacje = new HashSet<Rezerwacje>();
        }
    
        public int IdPokoju { get; set; }
        public int Numer { get; set; }
        public double CenaZaDobe { get; set; }
        public bool CzyWolny { get; set; }
        public bool CzyPosprzatany { get; set; }
        public int LiczbaMiejsc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rezerwacje> Rezerwacje { get; set; }
    }
}
