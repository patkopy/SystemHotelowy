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
    
    public partial class RachunkiZaUslugi
    {
        public int IdRachunkuZaUsluge { get; set; }
        public int IdKlienta { get; set; }
        public int IdUslugi { get; set; }
        public double Kwota { get; set; }
        public System.DateTime TerminZaplaty { get; set; }
        public bool CzyZaplacono { get; set; }
        public int IdPracownika { get; set; }
    
        public virtual Klienci Klienci { get; set; }
        public virtual Pracownicy Pracownicy { get; set; }
        public virtual Uslugi Uslugi { get; set; }
    }
}
