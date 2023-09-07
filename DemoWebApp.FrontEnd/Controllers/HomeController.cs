using DemoWebApp.Core.DTOs;
using DemoWebApp.FrontEnd.Models;
using DemoWebApp.FrontEnd.Services.Interfaces;
using DemoWebApp.FrontEnd.Utilities;
using DemoWebApp.FrontEnd.Utilities.AppSetting;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;

namespace DemoWebApp.FrontEnd.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAuthenticationService _service;
        private readonly ILogger<HomeController> _logger;
        private readonly IAppSeting _appSetting;

        public HomeController(
            ILogger<HomeController> logger,
            IAppSeting appSetting,
            IAuthenticationService service)
        {
            _logger = logger;
            _appSetting = appSetting;
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            request.Ip = _service.GetIp();
            return new JsonResult(await _service.Login(request));
        }

        public IActionResult Logout()
        {
            _service.LogOut();
            Response.Cookies.Delete(Constants.SessionKey.sessionLogin);
            Response.Cookies.Delete(Constants.SessionKey.accessToken);
            Response.Clear();

            return RedirectToAction("Login");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}