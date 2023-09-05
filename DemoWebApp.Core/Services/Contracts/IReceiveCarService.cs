using DemoWebApp.Core.Models;
using DemoWebApp.Core.Models.ReceiveCar;
using DemoWebApp.Core.Domain.Entities;

namespace DemoWebApp.Core.Services.Contracts
{
    public interface IReceiveCarService
    {
        Task<ResponseApi<List<SP_SEARCH_RC_Result>>> GetAllbySp(SearchModel model);
        Task<ResponseApi<List<T_JOB_REPO>>> GetAll();
        Task<bool> SaveFile(List<FileUploadModel> model);
        string GenerateAndDownLoadExcel();
        Task<ResponseApi<List<SP_SEARCH_RC_Result>>> GetList(SearchModel model);
        Task<ResponseApi<FileUploadModel>> Save(List<FileUploadModel> model);
    }
}
