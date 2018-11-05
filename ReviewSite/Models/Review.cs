using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        
        public string Content { get; set; }

        public virtual Category Category { get; set; }

        public virtual List<Comment> Comments { get; set; }

        public virtual List<Tags> Reviews { get; set; } // many to many: between review and tags 

        public int CategoryId{ get; set; }
    }

}
