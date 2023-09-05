using DemoWebApp.Core.DTOs;
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
        private readonly IBaseApiService<MasterDTO> _baseApiService;

        public MasterController(IAppSeting appSetting, IBaseApiService<MasterDTO> baseApiService)
        {
            _appSetting = appSetting;
            _baseApiService = baseApiService;
        }

        public async Task<IActionResult> Index()
        {
            var model = new MasterViewModel();
            try
            {
                var listMaster = await _baseApiService.GetListAsync(_appSetting.BaseUrlApi + "Master/GetListMasterActiveOnly");
                model.listMaster = listMaster.Value;
            }
            catch
            {
                throw;
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> GetList()
        {
            return new JsonResult(await _baseApiService.GetListAsync(_appSetting.BaseUrlApi + "Master/GetAll"));
        }

        [HttpPost]
        public IActionResult _Detail(string code, string action)
        {
            return PartialView();
        }
    }
}
