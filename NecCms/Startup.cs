using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Net.Http.Headers;
using NecCms.Database;
using NecCms.Database.Service;
using NecCms.Logger;
using NecCms.Models;
using SameSiteMode = Microsoft.AspNetCore.Http.SameSiteMode;

namespace NecCms
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<CrmContext>();
            services.AddFactory<IGenericService, GenericService>();
            services.AddFactory<ILoggerService, LoggerService>();
            services.AddFactory<IHttpContextAccessor, HttpContextAccessor>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles(new StaticFileOptions
            {
                OnPrepareResponse = ctx =>
                {
                    ctx.Context.Response.Headers[HeaderNames.CacheControl] =
                        "public,max-age=31536000";
                }
            });
            app.UseCookiePolicy();
            
            app.UseMiddleware<RequestResponseLoggingMiddleware>();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    "kategori",
                    "{kategori}",
                    new {controller = "Kategori", action = "Index"}
                );

                routes.MapRoute(
                    "kategori",
                    "{kategori}/sayfa/{skip?}",
                    new {controller = "Kategori", action = "Index"}
                );

                routes.MapRoute(
                    "icerik",
                    "{kategori}/{icerik}",
                    new {controller = "Icerik", action = "Index"}
                );

                routes.MapRoute(
                    "default",
                    "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }

    public static class ServiceCollectionExtensions
    {
        public static void AddFactory<TService, TImplementation>(this IServiceCollection services)
            where TService : class
            where TImplementation : class, TService
        {
            services.AddTransient<TService, TImplementation>();
            services.AddSingleton<Func<TService>>(x => () => x.GetService<TService>());
        }
    }
}