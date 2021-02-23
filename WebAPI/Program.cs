using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.DependencyResolvers.Autofac;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>//serverla ilgili konfigürasyonun olduð uyer
            Host.CreateDefaultBuilder(args)
                
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())//Startuptaki IOC yapýsý yerine Autofac kullan
                .ConfigureContainer<ContainerBuilder>(builder=>
                {
                    builder.RegisterModule(new AutofacBusinessModule());//IOC container olarak Autofacbusinessmodule kullan
                })

                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
