using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrarySeminarski;
using ClassLibrarySeminarski.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OnlineFitnessShop.Core.Interfaces;
using OnlineFitnessShop.Core.Services;
namespace OnlineFitnessShop
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
            services.AddDbContext<MyDbContext>(x => x.UseSqlServer(Configuration.GetConnectionString("localDB")));
            services.AddControllersWithViews();

            services.AddSession();

            services.AddScoped(typeof(IAdministratorRepository<>), typeof(AdministratorRepository<>));
            services.AddScoped(typeof(IKupacRepository<>), typeof(KupacRepository<>));
            services.AddTransient<IDobavljaciService, DobavljaciService>();
            services.AddTransient<IProizvodiService, ProizvodiService>();
            services.AddTransient<IUsersService, UsersService>();
            services.AddTransient<IProizvodiShopService, ProizvodiShopService>();
            services.AddTransient<IUserDataService, UserDataService>();
            services.AddTransient<IUserInterfaceService, UserInterfaceService>();
            services.AddTransient<IOrdersService, OrdersService>();
            services.AddTransient<IAutentifikacijaService, AutentifikacijaService>();


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
            app.UseSession();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=UserInterface}/{action=Home}/{id?}");
            });

        }
    }
}