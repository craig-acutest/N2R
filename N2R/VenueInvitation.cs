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
    
    public partial class VenueInvitation
    {
        public int ID { get; set; }
        public Nullable<int> User1ID { get; set; }
        public Nullable<int> User2ID { get; set; }
        public Nullable<int> VenueID { get; set; }
        public Nullable<bool> Accepted { get; set; }
        public Nullable<bool> Declined { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
    
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual Venue Venue { get; set; }
    }
}