 using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Portfolio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run(); // configurate a web server. Hosted by the internal server by default
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args) //do set up for the application based on some defaults 
                
                .UseStartup<Startup>() //The type that will start the configuration
                .Build();
    }
}
