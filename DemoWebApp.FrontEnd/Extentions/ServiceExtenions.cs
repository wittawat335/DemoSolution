using DemoWebApp.FrontEnd.Services;
using DemoWebApp.FrontEnd.Services.Interfaces;
using DemoWebApp.FrontEnd.Utilities.AppSetting;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace DemoWebApp.FrontEnd.Extentions
{
    public static class ServiceExtenions
    {
        public static void SessionConfig(this IServiceCollection services)
        {
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(option =>
            {
                option.LoginPath = "/Authentication/Login";
                option.ExpireTimeSpan = TimeSpan.FromMinutes(15);
            });

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "AspNetCore.Identity.Application";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(15);
                options.SlidingExpiration = true;
            }); // test
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>(); //Session
            services.AddDistributedMemoryCache();
            services.AddSession(option =>
            {
                option.IdleTimeout = TimeSpan.FromMinutes(15);
            });
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddSingleton<IAppSeting, AppSetting>();
            services.AddTransient(typeof(IBaseApiService<>), typeof(BaseApiService<>));
        }
    }
}
