using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PROJECT_QUIZ.Models.Data;
using PROJECT_QUIZ.Models.Models;

[assembly: HostingStartup(typeof(PROJECT_QUIZ.Areas.Identity.IdentityHostingStartup))]
namespace PROJECT_QUIZ.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder) 
        { 
            builder.ConfigureServices((context, services) => 
            { 
                services.AddDefaultIdentity<Person>(options => options.SignIn.RequireConfirmedAccount = false).AddRoles<IdentityRole>().AddEntityFrameworkStores<ProjectDBContext>();
            }); 
        }
    }
}