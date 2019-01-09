using System.Web.Mvc;
using Moot.Service.Interfaces;

namespace Moot.UI.Areas.Pannel.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

    }
}
