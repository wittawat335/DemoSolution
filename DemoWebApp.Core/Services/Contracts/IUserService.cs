using DemoWebApp.Core.Domain.Entities;
using DemoWebApp.Core.DTOs;
using DemoWebApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebApp.Core.Services.Contracts
{
    public interface IUserService
    {
        Task<ResponseApi<List<UserDTO>>> GetAll();
        Task<ResponseApi<UserDTO>> GetByUserLogin(string userLogin);
        Task<ResponseApi<LoginResponse>> CheckLogin(LoginRequest request);
        Task<ResponseApi<LoginResponse>> Login(LoginRequest request);
        Task<ResponseApi<UserDTO>> Insert(UserDTO request);
        Task<ResponseApi<UserDTO>> Update(UserDTO request);
        Task<ResponseApi<UserDTO>> Delete(UserDTO request);
        Task<ResponseApi<LoginResponse>> GenerateToken(M_USER user);
        Task<long> InsertCurrentLogin(M_USER user, string ip);
    }
}
