using System;
using System.Collections.Generic;
using Nancy;
using Nancy.ViewEngines.Razor;
using Microsoft.AspNetCore.Razor;
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
        Get("/dogs", _ => {
          Dictionary<string, object> model = new Dictionary<string, object> ();
          List<Dog> allDogs = Dog.GetAll();
          model.Add("allDogs", allDogs);
          return View["dogs.html", model];
        });

        //New Dog
        Post("/dogs", _ => {
          Dictionary<string, object> model = new Dictionary<string, object> ();
          Dog newDog = new Dog(Request.Form["name"]);
          newDog.Save();
          List<Dog> allDogs = Dog.GetAll();
          model.Add("Recentdog", newDog);
          model.Add("allDogs", allDogs);
          return View["add_dog.html", model];
        });

      }
  }
}
