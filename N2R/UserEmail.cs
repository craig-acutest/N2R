//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace N2R
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserEmail
    {
        public int ID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string Incoming { get; set; }
        public string InPass { get; set; }
        public string Outgoing { get; set; }
        public string OutPass { get; set; }
        public Nullable<bool> SSLEnabled { get; set; }
    
        public virtual User User { get; set; }
    }
}
