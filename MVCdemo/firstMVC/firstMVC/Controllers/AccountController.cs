using firstMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstMVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if(model.Username == "testas" && model.Password == "slaptazodis")
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.LoginError = "Blogas prisijungimas";
                return View();
            }

            
        }
    }
}
