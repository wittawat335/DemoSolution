using DemoWebApp.Domain.Entities;
using DemoWebApp.Web.Models;
using DemoWebApp.Web.Services.Contracts;
using DemoWebApp.Web.Utilities;
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

        [HttpPost]
        public async Task<IActionResult> GetList()
        {
            return new JsonResult(await _baseApiService.GetListAsync(_appSetting.BaseUrlApi + "Master/GetAll"));
        }
    }
}
