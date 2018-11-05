using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReviewSite.Models;

namespace ReviewSite
{
    public class TagsRepository : Repository<Tags>, ITagsRepository
    {
        
        public TagsRepository(Context context) : base(context)
        {
            // This ensures our base constructor gets run.
        }


    }
}
