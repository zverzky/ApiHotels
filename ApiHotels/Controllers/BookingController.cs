﻿using Microsoft.AspNetCore.Mvc;

namespace ApiHotels.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
