using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using PROJECT_QUIZ.Data;
using PROJECT_QUIZ.Models.Data;
using PROJECT_QUIZ.Models.Models;
using PROJECT_QUIZ.Models.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.OpenApi.Models;

namespace PROJECT_QUIZ.Api
{
    public class Startup
    {


        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;



        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {


            //1. Setup
            services.AddControllers(); //Enkel API controllers nodig

            //1.1 loophandling verhinderen
            services.AddMvc(options =>
            {
                options.EnableEndpointRouting = false;
                options.RespectBrowserAcceptHeader = true;
            }).AddNewtonsoftJson(options =>
            {
                //circulaire referenties verhinderen door navigatie props
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });

            //2. Registraties (van context, Identity) 
            //2.1. Context
            var connectionString = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ProjectDBContext>(options => options.UseSqlServer(connectionString));

            //2.2 Identity ( NIET de AddDefaultIdentity())
            services.AddIdentity<Person, IdentityRole>()
                .AddEntityFrameworkStores<ProjectDBContext>();

            //3 Registraties van Repos
            services.AddScoped<IQuizRepo, QuizRepo>();
            //services.AddScoped<IEducationRepo, EducationRepo>();
            //services.AddScoped<ITodoTaskRepo, TodoTaskRepo>();

            //4. open API documentatie
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1.0", new OpenApiInfo { Title = "ToDo_API", Version = "v1.0" });
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, RoleManager<IdentityRole> roleMgr, UserManager<Person> userMgr, ProjectDBContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //configuratie openAPI documentatie
            app.UseSwagger(); //enable swagger
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1.0/swagger.json", "ToDo_API v1.0");
                c.RoutePrefix = "swagger"; //path naar de UI pagina: /swagger/index.html
            });




            ////Seeder voor Identity & Data
            //SchoolDBContextExtensions.SeedRoles(roleMgr).Wait();  //zonder wait breekt de Task
            //SchoolDBContextExtensions.SeedUsers(userMgr).Wait();
            ////SchoolDBContextExtensions.SeedToDoTasks(repo).Wait();
            //context.SeedData().Wait(); //oproepen als extensiemetehode.




        }
    }
}
