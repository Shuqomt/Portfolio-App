using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portfolio.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Portfolio
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {// Registering services for our application.
            services.AddMvc(); //injected in the consuming class. 
            services.AddTransient<IPhotoshopRepository, PhotoshopRepository>(); 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
                app.UseDeveloperExceptionPage(); //it will make sure that when something goes wrong in application you will get acception || use only when developing app
                app.UseStatusCodePages();// show info about the status of request i.e. 400 or 500
                app.UseStaticFiles(); // will go and search by default and would return file from wwwroot ie. image or css files
                app.UseMvcWithDefaultRoute(); 

            //sequence in which added is important.

        }
    }
}
 //asp.net core is very lightweight and modular 
 //--nothing is enabled by default. so you enable using services and injecting. 