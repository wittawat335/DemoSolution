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
    public interface IProgramService
    {
        List<ProgramDTO> GetByRole(string code);
        Task<List<ProgramDTO>> GetByRoleAsync(string code);
        Task<string> GetMenuDefault(string code);
        Task<List<M_PROGRAM>> GetAll();
        Task<M_PROGRAM> GetByCode(string code);
        Task Add(M_PROGRAM model);
        Task Update(ProgramDTO model);
        Task Delete(string code);
        Task<ResponseApi<List<M_PROGRAM>>> GetList();
        Task<ResponseApi<ProgramDTO>> Detail(string code, string action);
        Task Save(ProgramDTO model);
    }
}
