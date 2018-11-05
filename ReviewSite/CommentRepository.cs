using ReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite
{
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {

        public CommentRepository(Context context) : base(context)
        {
            // This ensures our base constructor gets run.
        }
    
    }
}
