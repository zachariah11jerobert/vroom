using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vroom.Models;

namespace vroom.Controllers
{
    public class MakeController : Controller
    {
        public IActionResult Bikes()
        {
            Make make = new Make { Id = 1, Name = "Harley Davidson" };

            //return View(make);
            //return Controller("Hey this is the string from helper method");
            //return Redirect("/home");
            //return RedirectToAction("About", "Home");
            return new EmptyResult();

        }
    }
}