﻿using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace IdentityServerCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "IdentityServer";

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseUrls("http://localhost:5000") //from demo
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

           host.Run();
        }
    }
}
