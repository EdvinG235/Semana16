using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana16.Controllers
{
    public class HurtController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string bienvenida, string saludo, int edad)
        {
            ViewData["bienvenida"] = "Buenos dias " + bienvenida;
            ViewData["saludo"] = "Espero encuentres lo que buscas " + saludo;
            ViewData["edad"] = edad;


            return View();
        }
    }
}
