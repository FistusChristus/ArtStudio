using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MudBlazor.Services;
using Microsoft.EntityFrameworkCore;
using ArtStudio.Models;
using ArtStudio.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.ResponseCompression;
using ArtStudio.Data;

namespace ArtStudio
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            Extensions.SetConfiguration(configuration);
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<JSRuntimeService>();
           
            services.AddTransient<AuthenticationStateProvider, AuthStateProvider>();
     
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddMudServices();

            services.AddDistributedMemoryCache();

            services.AddSession();

            services.AddControllersWithViews();
            services.AddControllers();
            services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, ApplicationRole>().AddEntityFrameworkStores<ApplicationDBContext>();
            services.AddAuthentication();
                

            services.AddTransient<SessionService>();
            services.AddTransient<EntityService>();
            services.AddTransient<UserService>();
            services.AddTransient<HttpContextAccessor>();
            services.AddAuthorization(opts =>
            {
                opts.AddPolicy("Authorized", policy =>
                {
                    policy.RequireRole("User");
                });
                opts.AddPolicy("Admin", policy =>
                {
                    policy.RequireUserName(Configuration.GetSection("AdminUserName").Value);
                });

            });
            services.AddResponseCompression(opts =>
            {
                opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
                    new[] { "application/octet-stream" });
            });
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
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSession();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                      name: "default",
                      pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
