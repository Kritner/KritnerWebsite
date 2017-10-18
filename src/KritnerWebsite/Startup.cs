using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using KritnerWebsite.Data;
using KritnerWebsite.Models;
using KritnerWebsite.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Net;
using Microsoft.EntityFrameworkCore.Infrastructure;
using KritnerWebsite.Interfaces;
using KritnerWebsite.Repositories;
using AutoMapper;
using KritnerWebsite.Models.NewbornModels;
using KritnerWebsite.Models.NewbornViewModels;
using Microsoft.Extensions.FileProviders;
using System.IO;
using Microsoft.AspNetCore.Http;
using KritnerWebsite.Models.HomeModels;
using KritnerWebsite.Models.HomeViewModels;
using Microsoft.AspNetCore.Identity;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;

namespace KritnerWebsite
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
            // Add framework services.
            services.AddApplicationInsightsTelemetry(Configuration);

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options => {
                    options.LoginPath = "/Account/LogIn";
                    options.LogoutPath = "/Account/LogOff";
                });

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddLogging();
            services.AddMvc();

            // Add application services.
            services.AddTransient<IEmailSender, EmailSender>();
            services.AddTransient<IBlogRetrieval, BlogRetrievalService>();
            services.AddScoped<ICareGiverRepository, CareGiverRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app, 
            IHostingEnvironment env, 
            ILoggerFactory loggerFactory
        )
        {

            if (env.IsDevelopment())
            {
                loggerFactory.AddDebug(LogLevel.Information);
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
                app.UseBrowserLink();
            }
            else
            {
                loggerFactory.AddDebug(LogLevel.Error);
                app.UseExceptionHandler("/Shared/Error");
            }

            app.UseStaticFiles();

            // Allow static files within the .well-known directory to allow for automatic SSL renewal
            app.UseStaticFiles(new StaticFileOptions()
            {
                ServeUnknownFileTypes = true,
                FileProvider = new PhysicalFileProvider(
                        Path.Combine(Directory.GetCurrentDirectory(), @".well-known")),
                RequestPath = new PathString("/.well-known")
            });

            app.UseAuthentication();

            Mapper.Initialize(config =>
            {
                config.CreateMap<Address, AddressViewModel>().ReverseMap();
                config.CreateMap<CareGiver, CareGiverViewModel>().ReverseMap();
                config.CreateMap<BlogEntry, BlogEntryViewModel>().ReverseMap();
            });

            // Add external authentication middleware below. To configure them please see http://go.microsoft.com/fwlink/?LinkID=532715

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
