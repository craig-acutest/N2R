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
    
    public partial class UserEntertainer
    {
        public int ID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> EntertainerID { get; set; }
        public Nullable<int> Rating { get; set; }
    
        public virtual Entertainer Entertainer { get; set; }
        public virtual User User { get; set; }
    }
}
