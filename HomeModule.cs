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
          return View["about.html"];
        });
        //Greet page
        // Get("/greet/{name}", x => {
        //     return string.Concat("Hello ", x.name);
        // });

      }
  }
}
