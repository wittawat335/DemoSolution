using Microsoft.AspNetCore.Mvc;

namespace DemoWebApp.Web.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
