//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ObavijestiService
{
    using System;
    using System.Collections.Generic;
    
    public partial class dnevnik
    {
        public int dnevnik_id { get; set; }
        public int korisnik_id { get; set; }
        public int tip_radnja_id { get; set; }
        public string sadrzaj { get; set; }
        public System.DateTime datum_vrijeme { get; set; }
        public string sigurnosna_kopija_sql { get; set; }
    
        public virtual korisnik korisnik { get; set; }
        public virtual tip_radnja tip_radnja { get; set; }
    }
}
