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
    
    public partial class VenueType
    {
        public VenueType()
        {
            this.Venues = new HashSet<Venue>();
            this.VenueType1 = new HashSet<VenueType>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public Nullable<int> SubTypeID { get; set; }
    
        public virtual ICollection<Venue> Venues { get; set; }
        public virtual ICollection<VenueType> VenueType1 { get; set; }
        public virtual VenueType VenueType2 { get; set; }
    }
}
