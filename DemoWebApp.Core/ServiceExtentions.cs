﻿using DemoWebApp.Core.AutoMapper;
using DemoWebApp.Core.Helper;
using DemoWebApp.Core.Services;
using DemoWebApp.Core.Services.Contracts;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace DemoWebApp.Core
{
    public static class ServiceExtentions
    {
        public static void AddCore(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
            services.Configure<JwtSettings>(configuration.GetSection("JwtSettings"));
            services.AddAutoMapper(typeof(AutoMapperProfile));
            // Add Service
            services.AddTransient<IEmailService, EmailService>();
            services.AddScoped<IMasterService, MasterService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICommonService, CommonService>();
        }

        public static void AuthenticationConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = configuration["JwtSettings:Audience"],
                    ValidIssuer = configuration["JwtSettings:Issuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSettings:Key"]))
                };
            });
        }
    }
}
