using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppMyFilm.DAL.Interfaces.SQLInterfaces.ISQLRepositories;
using AppMyFilm.DAL.Interfaces.SQLInterfaces.ISQLServices;
using AppMyFilm.DAL.Repositories.SQL_Repositories;
using AppMyFilm.DAL.Services.SQL_Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using SkillManagement.DataAccess.Infrastructure;
using SkillManagement.DataAccess.Interfaces;
using SkillManagement.DataAccess.Interfaces.SQLInterfaces.ISQLRepositories;
using SkillManagement.DataAccess.Interfaces.SQLInterfaces.ISQLServices;
using SkillManagement.DataAccess.Repositories;
using SkillManagement.DataAccess.Repositories.SQL_Repositories;
using SkillManagement.DataAccess.Services;
using SkillManagement.DataAccess.Services.SQL_Services;
using SkillManagement.DataAccess.sqlunitOfWork;

namespace AppMyFilm
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
            services.AddControllers();

            #region SQL repositories
            services.AddTransient<ISQLEmployeeRepository, SQLEmployeeRepository>();
            services.AddTransient<ISQLSkillRepository, SQLSkillRepository>();
            services.AddTransient<ISQLScoreRepository, SQLScoreRepository>();
            services.AddTransient<ISQLEmployeeSkillRepository, SQLEmployeeSkillRepository>();
            services.AddTransient<ISQLFilmsRepository, SQLFilmsRepository>();
            #endregion

            #region SQL services
            services.AddTransient<ISQLEmployeeService, SQLEmployeeService>();
            services.AddTransient<ISQLSkillService, SQLSkillService>();
            services.AddTransient<ISQLScoreService, SQLScoreService>();
            services.AddTransient<ISQLEmployeeSkillService, SQLEmployeeSkillService>();
            services.AddTransient<ISQLFilmsService, SQLFilmsService>();
            #endregion

            services.AddTransient<ISQLUnitOfWork, SQLsqlunitOfWork>();

            services.AddTransient<IConnectionFactory, ConnectionFactory>();

            services.AddSingleton<IConfiguration>(Configuration);

            #region Swagger
            services.AddSwaggerGen();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Films API",
                    Description = "A simple example ASP.NET Core Web API",
                    TermsOfService = new Uri("https://github.com/Kolyanuss"),
                    Contact = new OpenApiContact
                    {
                        Name = "STEP Student",
                        Email = string.Empty,
                        Url = new Uri("https://github.com/Kolyanuss"),
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Use under LICX",
                    }
                });
            });
            #endregion

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });


            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
