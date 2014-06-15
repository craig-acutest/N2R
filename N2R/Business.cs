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
    
    public partial class Business
    {
        public Business()
        {
            this.BusinessUsers = new HashSet<BusinessUser>();
            this.BusinessVenues = new HashSet<BusinessVenue>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public string Desctription { get; set; }
        public Nullable<int> AddressID { get; set; }
    
        public virtual Address Address { get; set; }
        public virtual ICollection<BusinessUser> BusinessUsers { get; set; }
        public virtual ICollection<BusinessVenue> BusinessVenues { get; set; }
    }
}