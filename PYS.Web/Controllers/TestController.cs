﻿using Microsoft.AspNetCore.Mvc;

namespace PYS.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
