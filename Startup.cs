using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using LICEORURALJASMINEZB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LICEORURALJASMINEZ.Utilidades;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace LICEORURALJASMINEZB
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
            services.AddDbContext<ApplicationDbContext>(options =>
                  options.UseSqlServer(
                      Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<IdentityUser, IdentityRole>().AddDefaultTokenProviders()
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddSingleton<IEmailSender, EmailSender>();
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddRazorPages(); ;
            //Soporte para autorizaci�n basada en directivas/ Policy
            services.AddAuthorization(options =>
            {
                options.AddPolicy("Administrador", policy => policy.RequireRole("Administrador"));
                options.AddPolicy("Registrado", policy => policy.RequireRole("Registrado"));
                options.AddPolicy("Usuario", policy => policy.RequireRole("Usuario"));
                options.AddPolicy("UsuarioYAdministrador", policy => policy.RequireRole("Administrador").RequireRole("Usuario"));

                //Uso de claims
                options.AddPolicy("AdministradorCrear", policy => policy.RequireRole("Administrador").RequireClaim("Crear", "True"));
                options.AddPolicy("AdministradorEditarBorrar", policy => policy.RequireRole("Administrador").RequireClaim("Editar", "True").RequireClaim("Borrar", "True"));
                options.AddPolicy("AdministradorCrearEditarBorrar", policy => policy.RequireRole("Administrador").RequireClaim("Crear", "True")
                .RequireClaim("Editar", "True").RequireClaim("Borrar", "True"));
            });

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = $"/Identity/Account/Login";
                options.LogoutPath = $"/Identity/Account/Logout";
                options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
            });

            //Soporte para autorizaci�n basada en directivas/Policy

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
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

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{area=Admin}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
