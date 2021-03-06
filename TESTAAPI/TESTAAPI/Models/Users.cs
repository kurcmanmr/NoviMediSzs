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
    
    public partial class Users
    {
        public int UserID { get; set; }
        public Nullable<int> GroupID { get; set; }
        public string SifraKorisnika { get; set; }
        public string Titula { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public string Tel_1 { get; set; }
        public string Tel_2 { get; set; }
        public string Adresa { get; set; }
        public Nullable<int> MjestoID { get; set; }
        public string Gsm { get; set; }
        public string Napomena { get; set; }
        public Nullable<System.DateTime> C_DateCreated { get; set; }
        public Nullable<System.DateTime> C_DateUpdated { get; set; }
        public Nullable<int> C_KorisnikID { get; set; }
        public Nullable<bool> Neaktivan { get; set; }
        public Nullable<bool> Ispis { get; set; }
        public Nullable<bool> Daktilograf { get; set; }
        public Nullable<bool> Opticar { get; set; }
        public Nullable<bool> OpciKorisnik { get; set; }
        public Nullable<bool> SobaNalazID { get; set; }
        public string Oib { get; set; }
        public Nullable<bool> NalaziFilter { get; set; }
        public string ENarUserName { get; set; }
        public string ENarUserPass { get; set; }
        public string MBOUser { get; set; }
        public Nullable<bool> ENarOpen { get; set; }
        public Nullable<bool> ENarPreuzimanje { get; set; }
        public Nullable<bool> ENarRezervacija { get; set; }
        public Nullable<bool> Lijecnik { get; set; }
        public Nullable<bool> ENarCreateOperater { get; set; }
        public Nullable<bool> ENarCreateRadiliste { get; set; }
        public Nullable<bool> ENarRadilistaZahvati { get; set; }
        public Nullable<bool> ENarRadilistaOsobe { get; set; }
        public string ENarSifraHzjz { get; set; }
        public Nullable<bool> ENarEvidencijaDolaska { get; set; }
        public Nullable<int> AccountLastID { get; set; }
        public Nullable<bool> AccountAutoLogin { get; set; }
        public Nullable<int> FunkcijaID { get; set; }
        public Nullable<bool> Spol { get; set; }
        public Nullable<int> ProfitniCentarID { get; set; }
        public Nullable<bool> Aktivan { get; set; }
        public string JMBG { get; set; }
        public Nullable<int> TipHZZOID { get; set; }
        public string TitulaPrefiks { get; set; }
        public string Specijalnost { get; set; }
        public Nullable<int> SobaID { get; set; }
        public string Sifra { get; set; }
        public Nullable<int> OldID { get; set; }
        public Nullable<bool> OdabirRacuni { get; set; }
        public string MaticniBroj { get; set; }
        public string LijecnikPrikaz { get; set; }
        public string InstanceIdentifier { get; set; }
        public Nullable<bool> HrDijagnoze { get; set; }
        public string HcProviderUniqueIdentifier { get; set; }
        public string HcOrganizationInstanceIdentifier { get; set; }
        public string EMail { get; set; }
        public string CezihKartica { get; set; }
        public byte[] CezihLicenca { get; set; }
    }
}
