using System.Web.Mvc;
using Moot.Service.Interfaces;
using Moot.Service.Messages.Contacts;
using Moot.Service.ViewModels;

namespace Moot.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContactService _contactService;

        public HomeController(IContactService contactService)
        {
            _contactService = contactService;
        }


        /// <summary>
        /// Default page of WebSite
        /// </summary>
        /// <returns></returns>
        public ViewResult Index()
        {
            return View();
        }



        /// <summary>
        /// Make Contact By Users
        /// </summary>
        /// <returns></returns>
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactViewModel contactViewModel)
        {
            var creatContactRequest = new CreateContactRequest()
                {
                    Body = contactViewModel.Body,
                    Email = contactViewModel.Email,
                    Name = contactViewModel.Name,
                    Title = contactViewModel.Title
                };

            if (ModelState.IsValid)
            {
                _contactService.CreateContact(creatContactRequest);
            }
            return View();
        }
    }
}
