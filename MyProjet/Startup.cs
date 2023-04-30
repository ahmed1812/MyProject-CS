using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyProjet.Data.Entity;
using MyProjet.Data.Relationship;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MyProjet
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
            services.AddControllersWithViews();
            services.AddScoped<IDbConnection>((s) =>
            {
                IDbConnection conn = new MySqlConnection(Configuration.GetConnectionString("bestbuy"));
                conn.Open();
                return conn;
            });

            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IReviewRepository, ReviewRepository>();
            services.AddTransient<IJoinRepo, JoinRepo>();
            services.AddTransient<IJoin3Tables, Join3Tables>();
            services.AddTransient<IJoin8, Join8>();
            services.AddTransient<IEmployeeRepo, EmployeeRepo>();
            services.AddTransient<ISaleRepo, SaleRepo>();
            services.AddTransient<IDepartmentRepo, DepartmentRepo>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
