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
    
    public partial class BusinessVenue
    {
        public int ID { get; set; }
        public Nullable<int> BusinessID { get; set; }
        public Nullable<int> VenueID { get; set; }
    
        public virtual Business Business { get; set; }
        public virtual Venue Venue { get; set; }
    }
}
