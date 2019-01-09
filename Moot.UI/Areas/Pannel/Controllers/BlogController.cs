using System.Web.Mvc;
using Moot.Service.Interfaces;
using Moot.Service.ViewModels;

namespace Moot.UI.Areas.Pannel.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        /// <summary>
        /// Post Lists of web site's blog post
        /// </summary>
        /// <returns></returns>
        public ActionResult List()
        {
            
            return View();
        }


        /// <summary>
        /// Create post list
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(BlogViewModel blogViewModel)
        {
            return View();
        }

    }
}
