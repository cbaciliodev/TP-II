﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SGIAMTP.Models;

namespace SGIAMTP
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


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);


            var connection = @"Server=sql5047.site4now.net;Database=DB_A4F05E_SGIAMTP;User Id=DB_A4F05E_SGIAMTP_admin;Password=123456789gg;MultipleActiveResultSets=True;ConnectRetryCount=0";
            //var connection = @"Data Source=LENOVO;Initial Catalog=DB_A4F05E_SGIAMTP;Integrated Security=True";
            //var connection = @"Data Source=LACING202A-06;Initial Catalog=DB_A4F05E_SGIAMTP;Integrated Security=True";
            services.AddDbContext<DB_A4F05E_SGIAMTPContext>(options => options.UseSqlServer(connection));

            //Data Source=LACING202A-06;Initial Catalog=DB_A4F05E_SGIAMTP;Integrated Security=True

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
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Acces}/{action=Acces}/{id?}");
                    //template: "{controller=AdministarParticipante}/{action=Index}/{id?}");
        });
        }
    }
}
