using System;
using System.Collections.Generic;
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
          var model = new Task("Walk the dog.");
          return View["about.html", model];
        });

      }
  }
}
