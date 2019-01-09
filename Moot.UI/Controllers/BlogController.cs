using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Moot.Service.Interfaces;
using Moot.Service.Messages.Blogs;
using Moot.Service.ViewModels;

namespace Moot.UI.Controllers
{
    public class BlogController : Controller
    {

        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }
        

        /// <summary>
        /// List of All Post of website
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var request = new GetPostRequest();
            var posts = _blogService.GetAllPost(request);
            return View(posts);
        }


        /// <summary>
        /// Returns the post
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        public ActionResult Post(Guid postId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Posts(BlogViewModel blogViewModel)
        {
            return View();
        }

    }
}
