﻿using Microsoft.AspNetCore.Mvc;

namespace DemoWebApp.Web.Controllers
{
    public class RoleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
