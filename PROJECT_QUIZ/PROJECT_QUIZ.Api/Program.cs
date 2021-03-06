using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore; //nodig voor de migratie
using Microsoft.Extensions.DependencyInjection; //toegevoegd
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PROJECT_QUIZ.Models.Data;

namespace PROJECT_QUIZ.Api
{
    public class Program
    {
        //public static void Main(string[] args)
        //{
        //    CreateHostBuilder(args).Build().Run();
        //}

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });


        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Threading.Thread.Sleep(2000);
            }


            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    var context = services.GetRequiredService<ProjectDBContext>();
                    // context.Database.EnsureDeleted();//verwijder (-> niet doen in productie)
                    context.Database.EnsureCreated(); //maakt db aan volgens modellen
                    context.Database.Migrate();//voert migraties uit

                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "EnsureCreated: An error occurred creating the DB.");
                }
            }
            host.Run();
        }

    }
}
