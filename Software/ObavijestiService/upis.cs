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
    
    public partial class upis
    {
        public int upis_id { get; set; }
        public int korisnik_id { get; set; }
        public int dijete_id { get; set; }
        public System.DateTime datum_upis { get; set; }
    
        public virtual dijete dijete { get; set; }
        public virtual korisnik korisnik { get; set; }
    }
}
