using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite.Controllers
{
    public class CommentController : Controller
    {
        private ICommentRepository commentRepo;

        public CommentController(ICommentRepository commentRepo)
        {
            this.commentRepo = commentRepo;
        }

        public ViewResult Index()
        {
            var model = commentRepo.GetAll();
            return View(model);

        }

        public ViewResult Details(int id)
        {
            var model = commentRepo.FindOneReviewById(id);
            return View(model);

        }
    }
}
