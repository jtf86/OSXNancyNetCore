using System.Collections.Generic;
using System;
using Nancy;
using Nancy.ViewEngines.Razor;

namespace coreNancy
{
  public class Module : NancyModule
  {
      public Module()
      {
          Get("/greet/{name}", x => {
              return string.Concat("Hello ", x.name);
          });
      }
  }
}
