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
    
    public partial class LogCode
    {
        public LogCode()
        {
            this.Logs = new HashSet<Log>();
        }
    
        public int ID { get; set; }
        public Nullable<int> Code { get; set; }
        public string Title { get; set; }
    
        public virtual ICollection<Log> Logs { get; set; }
    }
}
