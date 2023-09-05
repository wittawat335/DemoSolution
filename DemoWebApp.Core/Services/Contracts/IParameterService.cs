using DemoWebApp.Core.DTOs;
using DemoWebApp.Core.Models;
using DemoWebApp.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebApp.Core.Services.Contracts
{
    public interface IParameterService
    {
        Task<ResponseApi<ParameterDTO>> GetAll(string action);
        Task<ResponseApi<ParameterDTO>> GetByCode(string code);
        Task<ResponseApi<bool>> Save(List<ParameterDTO> model);
        Task<ResponseApi<ParameterDTO>> postSave(List<ParameterDTO> Para);
    }
}
