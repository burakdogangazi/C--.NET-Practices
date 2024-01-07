using AspNetCoreMvcIntroduction.Models;
using AspNetCoreMvcIntroduction.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using AspNetCoreMvcIntroduction.Identity;
using Microsoft.AspNetCore.Identity;
using System.IO;

namespace AspNetCoreMvcIntroduction
{
    public class Startup
    {
        private IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options => options.EnableEndpointRouting = false);//Confige mvc ekledik ilk �nce yap�l�r
            services.AddDbContext<SchoolContext>(options => options.UseSqlServer(_configuration["dbConnection"]));

            services.AddDbContext<AppIdentityDbContext>(options => options.UseSqlServer(_configuration["dbConnection"]));

            services.AddIdentity<AppIdentityUser, AppIdentityRole>()
                .AddEntityFrameworkStores<AppIdentityDbContext>()
                .AddDefaultTokenProviders();
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.AllowedForNewUsers = true;

                options.User.RequireUniqueEmail = true;

                options.SignIn.RequireConfirmedEmail = true;
                options.SignIn.RequireConfirmedPhoneNumber = false;

            });

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Security/Login";
                options.LogoutPath = "/Security/Logout";
                options.AccessDeniedPath = "/Security/AccessDenied";
                options.SlidingExpiration = true; // cookie default s�resi 20 dakika ise siteye yeniden girince 20 dakika resetlenir.
                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true,//client script ile de eri�im sa�lanabilir.
                    Name=".AspNetCoreDemo.Security.Cookie",
                    Path="/", //tutaca�� noktaroute a koyar direkt
                    SameSite = SameSiteMode.Lax,//g�venliki�in
                    SecurePolicy = CookieSecurePolicy.SameAsRequest
                };
                
            });
            services.AddScoped<ICalculator, Calculator18>();
            //addsingleton ilk kullan�c� bir �eyler olu�turur ve haf�za da kal�r 2 . kullan�c� da eri�inde ayn� sonu� verilir.
            // insert update delete i�in kullan�l�r. �ok fazla kullan�lan ama sadece i�lem yapan
            // add singleton �ok s�k �a��r�lanlardan kullan�l�r.
            // addscoped bir istekte bulununca yap�lan her istekte servisin �rne�i olu�turur.
            // 1. kullan�c� i�in nesne 2. kullan�c� i�in nesne i�lem bitince silinir.
            // add transient her esnekte �rnek olu�ur. addscopedan fark� transientta ctor employeecalculator i�indeki iki tane controller olsun ama ad� controller2 denir. i�inde ayr� instane retilir
            //scpode da ikiside �calculoatr kabul edilir ikisi de ayn�
            services.AddSession();
            services.AddDistributedMemoryCache(); // SESS�ON i�in uygulama sunucusu haf�zas�nda tutar
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        [Obsolete]
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles(); // static dosyalar� kullanabilmek ad�na yazd�k wwwroot i�indekiler i�in

            env.EnvironmentName = Microsoft.AspNetCore.Hosting.EnvironmentName.Production; //ger�ek program web sayfas�nda kullan�c� nas�k g�r�r

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/error");
            }
            app.UseSession(); // session middleware

            app.UseRouting();

            app.UseAuthentication();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        //await context.Response.WriteAsync("Hello World!");

            //    });
            //});

            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller=home}/{action=index}/{id?}"
            //        );  //Id opsiyoneldir demi� olduk ? i�areti ile


            //});

            //app.UseMvc(ConfigureRoutes);

            app.UseMvcWithDefaultRoute(); //�STTEK�N�N AYNISI
        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute("Default", "{controller = Home}/{action=Index2}/{id?}");
            routeBuilder.MapRoute("MyRoute", "Burak/{controller = Home}/{action=Index2}/{id?}");

            routeBuilder.MapRoute(
                  name: "areas",
                  template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
            );

        }
    }

    //This is still an issue in Visual Studio Community 2015, Update 3 edition when creating an ASP.NET Core Web Application (.NET Framework 4.5.2) using the the Empty ASP.NET Core Template. It does appear to function properly when creating the project using the ASP.NET Core Web Application Template.

    //As the op mentioned the message is misleading since the dependencies are installed. It seems to be just a misreporting by Visual Studio that the npm and the dependencies are not installed. The temporary fix is to override where Visual Studio is looking for node.js, which removes the not installed messages in visual studio.

    //In Visual Studio go to Tools > Options > Projects and Solutions > External Web Tools and add a path to your installation of node.js. This is by default located at C:\Program Files\nodejs\ or C:\Program Files (x86)\nodejs\ Move this new line to the top or at least above the $(VSINSTALLDIR)\Web\External line.
}
