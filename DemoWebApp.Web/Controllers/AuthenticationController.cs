using Microsoft.AspNetCore.Mvc;

namespace DemoWebApp.Web.Controllers
{
    public class AuthenticationController : Controller
    {
        [HttpPost]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register()
        {
            return View();
        }
    }
}
