using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite.Models
{
    public class Tags
    {
        public int Id { get; set; }
        
        public string Text { get; set; }

        //[JsonIgnore]

        public virtual List<Review> Reviews { get; set; } // many to many: between review and tags
            
    }
}
