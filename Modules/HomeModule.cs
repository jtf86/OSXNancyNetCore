using System.Collections.Generic;
using System;
using Nancy;
using Nancy.ViewEngines.Razor;

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

        Get("/about", _ => {
          var model = "I AM THE MODEL";
          return View["about.html", model];
        });
        //Greet page
        // Get("/greet/{name}", x => {
        //     return string.Concat("Hello ", x.name);
        // });

      }
  }
}
