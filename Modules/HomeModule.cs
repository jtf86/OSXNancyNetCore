using System.Collections.Generic;
using System;
using Nancy;
using Nancy.ViewEngines.Razor;
using coreNancy.Objects;

namespace coreNancy
{
  public class HomeModule : NancyModule
  {
      public HomeModule()
      {
        //Index
        Get("/", _ => {
          return View["index.html"];
        });
        //About
        Get("/about", _ => {
          var model = new Task();
          model.Description = "Walk the dog.";
          return View["about.html", model];
        });
        //Greet page
        // Get("/greet/{name}", x => {
        //     return string.Concat("Hello ", x.name);
        // });

      }
  }
}
