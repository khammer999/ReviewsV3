using ReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite
{
      public interface ITagsRepository
    {

        IEnumerable<Tags> GetAll();
        Tags FindOneTagsById(int id);

    }
}
