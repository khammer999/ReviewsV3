using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite.Controllers
{
    public class TagsController : Controller
    {
        private ITagsRepository tagsRepo;

        public TagsController(ITagsRepository tagsRepo)
        {
            this.tagsRepo = tagsRepo;
        }

        public ViewResult Index()
        {
            var model = tagsRepo.GetAll();
            return View(model);

        }

        public ViewResult Details(int id)
        {
            var model = tagsRepo.FindOneTagsById(id);
            return View(model);

        }

    }
}
