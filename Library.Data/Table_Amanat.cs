//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table_Amanat
    {
        public int Id { get; set; }
        public System.DateTime TarikheAmanat { get; set; }
        public System.DateTime TarikheTahvil { get; set; }
        public string TitleBook { get; set; }
        public string Vazyat { get; set; }
        public string Member { get; set; }
    
        public virtual Table_Amanat Table_Amanat1 { get; set; }
        public virtual Table_Amanat Table_Amanat2 { get; set; }
    }
}
