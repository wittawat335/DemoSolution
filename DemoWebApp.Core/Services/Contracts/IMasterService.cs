using DemoWebApp.Core.DTOs;
using DemoWebApp.Core.Models;
using DemoWebApp.Core.Models.Master;

namespace DemoWebApp.Core.Services.Contracts
{
    public interface IMasterService
    {
        Task<ResponseApi<List<MasterDTO>>> GetAll(SearchModel model = null);
        Task<ResponseApi<List<MasterDTO>>> GetListByMasterType(string code);
        Task<ResponseApi<List<MasterDTO>>> GetListMasterActiveOnly();
        Task<ResponseApi<MasterDTO>> GetByCode(string code);
        Task<ResponseApi<MasterDTO>> Insert(MasterDTO model);
        Task<ResponseApi<MasterDTO>> Update(MasterDTO model);
        Task<ResponseApi<MasterDTO>> Delete(string code);
    }
}
