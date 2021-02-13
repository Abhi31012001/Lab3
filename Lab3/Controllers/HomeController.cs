using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Lab3.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Razor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Count()
        {
            HttpContext.Session.SetString("Bottle", Request.Form["Bottle"]);
            // HttpContext.Session.SetString("password", Request.Form["password"]); // note you probably wouldn't normally save this value
            // ViewBag.Bottle = Request.Form["Bottle"];
            return View();
        }

        public IActionResult CreatePerson()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DisplayPerson(Person model)
        {

            return View(model);
        }

    }
}
