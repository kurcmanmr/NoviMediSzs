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
    
    public partial class Iskaznice
    {
        public int IskaznicaID { get; set; }
        public int PacijentID { get; set; }
        public Nullable<int> VrijediOd { get; set; }
        public Nullable<int> VrijediDo { get; set; }
        public Nullable<int> PodrucniUred { get; set; }
        public string BrojOsiguraneOsobe { get; set; }
        public Nullable<int> OsnovaOsiguranja { get; set; }
        public string BrojObveze { get; set; }
        public string Drzava { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<System.DateTime> C_DateCreated { get; set; }
        public Nullable<System.DateTime> C_DateModified { get; set; }
        public string MbSmart { get; set; }
        public Nullable<bool> Smart { get; set; }
        public Nullable<int> OldID { get; set; }
        public Nullable<int> AccountID { get; set; }
    }
}