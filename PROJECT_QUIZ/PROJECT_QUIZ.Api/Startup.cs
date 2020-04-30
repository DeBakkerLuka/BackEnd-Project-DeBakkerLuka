using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using PROJECT_QUIZ.Models.Data;
using PROJECT_QUIZ.Models.Models;
using PROJECT_QUIZ.Models.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authentication.Cookies;
using System;

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
            services.AddScoped<IQuestionsRepo, QuestionsRepo>();
            services.AddScoped<IAnswersRepo, AnswersRepo>();
            services.AddScoped<IHistoryRepo, HistoryRepo>();

            //4. open API documentatie
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1.0", new OpenApiInfo { Title = "ToDo_API", Version = "v1.0" });
              
            });

            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());
            });
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters()
                { ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = Configuration["Tokens:Issuer"],
                    ValidAudience = Configuration["Tokens:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Tokens:Key"])) 
                }; 
                options.SaveToken = false;
                options.RequireHttpsMetadata = false;
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, RoleManager<IdentityRole> roleMgr, UserManager<Person> userMgr, ProjectDBContext context)
        {


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else 
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseCors(options => options.AllowAnyOrigin());

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

            app.UseMvc();

            ////Seeder voor Identity & Data
            //SchoolDBContextExtensions.SeedRoles(roleMgr).Wait();  //zonder wait breekt de Task
            //SchoolDBContextExtensions.SeedUsers(userMgr).Wait();
            ////SchoolDBContextExtensions.SeedToDoTasks(repo).Wait();
            //context.SeedData().Wait(); //oproepen als extensiemetehode.



        }
    }
}
