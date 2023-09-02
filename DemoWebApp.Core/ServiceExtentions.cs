using DemoWebApp.Core.AutoMapper;
using DemoWebApp.Core.Services;
using DemoWebApp.Core.Services.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace DemoWebApp.Core
{
    public static class ServiceExtentions
    {
        public static void AddCore(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperProfile));

            // RegisterService
            services.AddScoped<IMasterService, MasterService>();
        }
    }
}
