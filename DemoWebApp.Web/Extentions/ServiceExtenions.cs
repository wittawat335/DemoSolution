using DemoWebApp.Web.Services.Contracts;
using DemoWebApp.Web.Services;
using DemoWebApp.Web.Utilities.AppSetting;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace DemoWebApp.Web.Extentions
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
