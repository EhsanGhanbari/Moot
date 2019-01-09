using System.Web.Mvc;
using Moot.Service.Interfaces;

namespace Moot.UI.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }


    }
}
