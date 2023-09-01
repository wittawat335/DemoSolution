using Microsoft.AspNetCore.Mvc;

namespace DemoWebApp.Web.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
