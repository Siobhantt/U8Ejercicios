﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using U8Ej2.Models;

namespace U8Ej2.Controllers
{
    public class HomeController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(String nombre)
        {

            ViewBag.Nombre = nombre;
            return View("Saludo");
        }

    }
}