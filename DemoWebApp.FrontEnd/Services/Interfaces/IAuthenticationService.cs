using DemoWebApp.Core.DTOs;
using DemoWebApp.Core.Models;

namespace DemoWebApp.FrontEnd.Services.Interfaces
{
    public interface IAuthenticationService
    {
        Task<ResponseApi<LoginResponse>> Login(LoginRequest request);
        string GetIp();
        void LogOut();
        void SetSessionValue(LoginResponse response);
    }
}
