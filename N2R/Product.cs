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
    
    public partial class Product
    {
        public Product()
        {
            this.VenueProducts = new HashSet<VenueProduct>();
            this.OrderProducts = new HashSet<OrderProduct>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<bool> Recurring { get; set; }
        public Nullable<int> PromotionID { get; set; }
        public Nullable<int> TypeID { get; set; }
    
        public virtual ICollection<VenueProduct> VenueProducts { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
