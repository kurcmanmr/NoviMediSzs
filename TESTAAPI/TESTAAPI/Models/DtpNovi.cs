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
    
    public partial class DtpNovi
    {
        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public Nullable<double> Koeficijent { get; set; }
        public Nullable<double> CijenaFull { get; set; }
        public Nullable<double> Cijena { get; set; }
        public bool Aktivno { get; set; }
        public string DodatniObracun { get; set; }
        public string SljedeciPopust { get; set; }
        public string SljedeciPopustPosto { get; set; }
        public string SljedeciPopustOd { get; set; }
    }
}