﻿using Microsoft.AspNetCore.Mvc;

namespace villa.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
