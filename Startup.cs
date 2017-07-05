using System;
using System.IO;
using Microsoft.AspNetCore.Builder;
using Nancy;
using Nancy.Owin;

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

}
