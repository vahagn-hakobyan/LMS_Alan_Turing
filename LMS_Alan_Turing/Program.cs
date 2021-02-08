using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS_Alan_Turing.Controllers;
using LMS_Alan_Turing.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace LMS_Alan_Turing
{
    public class Program
    {
        
        
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();


            var context = new Alan_TuringContext();
            var studentsWithSameName = context.Users
                                              .Where(s => s.FirstName == GetName())
                                              .ToList();
        }

        public static string GetName()
        {
            return "Ruzanna";

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
