using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;

namespace VehicleManagementAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args)
                .Run();
        }

        private static IWebHost BuildWebHost(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseSerilog()
                .UseHealthChecks("/hc")
                .UseStartup<Startup>()
                .Build();
        }
    }
}
