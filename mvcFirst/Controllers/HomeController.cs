using firstMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(InputViewModel model)
        {
            string someString = "hello";

            object someObject = "world";

            var manoObjektas = new ManoTest();

            
            //manoObjektas.Skaicius = i;


            ViewBag.manoString = someString;

            ViewData["foo"] = someString;

            TempData["bar"] = someString;


            if (ModelState.IsValid)
            {
                return View("Index", model);
            }
            else
            {
                return View("Error");
            }

            //return View("Index", model);

            //return View(someObject);
        }

        public IActionResult Verslas(string q)
        {
            return View();
        }
    }
}
