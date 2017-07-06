using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Razor;
// using Microsoft.AspNetCore.Mvc;
using Nancy;
using Nancy.Owin;
// using Nancy.ViewEngines.Razor;

namespace coreNancy
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            // environment.Tracing(enabled: false, displayErrorTraces: true);
            app.UseOwin(x => x.UseNancy());
        }
    }

    public class CustomRootPathProvider : IRootPathProvider
    {
        public string GetRootPath()
        {
            return Directory.GetCurrentDirectory();
        }
    }

    public static class DBConfiguration
    {
      public static string ConnectionString = "Server=localhost;Database=doglist;User Id=sa;Password=Epic0dus";
    }

    // public class RazorConfig : IRazorConfiguration
    // {
    //     public IEnumerable<string> GetAssemblyNames()
    //     {
    //         return null;
    //     }
    //
    //     public IEnumerable<string> GetDefaultNamespaces()
    //     {
    //         return null;
    //     }
    //
    //     public bool AutoIncludeModelNamespace
    //     {
    //         get { return false; }
    //     }
    // }

}
