//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TESTAAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DjelatnostiZZ
    {
        public int DjelatnostID { get; set; }
        public string Sifra { get; set; }
        public string NazivDjelatnosti { get; set; }
        public Nullable<System.DateTime> DatumPocetka { get; set; }
        public Nullable<System.DateTime> DatumZavrsetka { get; set; }
        public string Napomena { get; set; }
        public Nullable<int> PodkategorijaID { get; set; }
    }
}
