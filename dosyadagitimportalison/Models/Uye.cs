//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dosyadagitimportalison.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Uye
    {
        public int UyeId { get; set; }
        public string UyeAdSoyad { get; set; }
        public string UyeMail { get; set; }
        public int YetkiId { get; set; }
        public System.DateTime UyeTarih { get; set; }
        public int UyeParola { get; set; }
    
        public virtual Dosyalar Dosyalar { get; set; }
        public virtual Yetki Yetki { get; set; }
    }
}
