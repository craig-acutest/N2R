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
    
    public partial class Entertainer
    {
        public Entertainer()
        {
            this.EventEntertainers = new HashSet<EventEntertainer>();
            this.UserEntertainers = new HashSet<UserEntertainer>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Nullable<int> ImageID { get; set; }
        public Nullable<int> TypeID { get; set; }
        public Nullable<int> Rating { get; set; }
    
        public virtual ICollection<EventEntertainer> EventEntertainers { get; set; }
        public virtual ICollection<UserEntertainer> UserEntertainers { get; set; }
    }
}
