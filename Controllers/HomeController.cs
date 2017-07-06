using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using coreMvc.Objects;

namespace coreMvc
{
  public class AppController : Controller
  {
        //Index
        // Get("/", _ => {
        //   return View["index.html"];
        // });
        public IActionResult Index()
        {
          return View();
        }

        //About
        // Get("/about", _ => {
        //   var model = new Task("Walk the dog.");
        //   return View["about.html", model];
        // });
        public IActionResult About()
        {
          var model = new Task("Walk the dog.");
          return View(model);
        }


  }
}
