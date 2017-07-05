using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Nancy.Owin;
using Nancy;
using System.IO;
using System.Data;

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
            Console.WriteLine(Directory.GetCurrentDirectory());
            return Directory.GetCurrentDirectory();
        }
    }

}
