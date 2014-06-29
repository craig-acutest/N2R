using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2R.Utilities.Models
{
    public class EmailModel
    {
        public int ID { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public DateTime DateSent { get; set; }
        public string Content { get; set; }
        public List<string> CCList { get; set; }
    }
}
