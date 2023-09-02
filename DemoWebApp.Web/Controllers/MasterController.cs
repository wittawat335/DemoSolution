using DemoWebApp.Web.Models;
using DemoWebApp.Web.Services.Contracts;
using DemoWebApp.Web.Utilities.AppSetting;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebApp.Web.Controllers
{
    public class MasterController : Controller
    {
        private readonly IAppSeting _appSetting;
        private readonly IBaseApiService<MasterViewModel> _baseApiService;

        public MasterController(IAppSeting appSetting, IBaseApiService<MasterViewModel> baseApiService)
        {
            _appSetting = appSetting;
            _baseApiService = baseApiService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
