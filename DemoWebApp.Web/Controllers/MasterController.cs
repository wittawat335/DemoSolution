using Microsoft.AspNetCore.Mvc;

namespace DemoWebApp.Web.Controllers
{
    public class MasterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
