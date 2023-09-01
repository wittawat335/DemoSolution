using Microsoft.AspNetCore.Mvc;

namespace DemoWebApp.Web.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
