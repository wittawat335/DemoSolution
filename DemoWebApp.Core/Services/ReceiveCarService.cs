using DemoWebApp.Core.Models;
using DemoWebApp.Core.Models.ReceiveCar;
using DemoWebApp.Core.Services.Contracts;
using DemoWebApp.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebApp.Core.Services
{
    public class ReceiveCarService : IReceiveCarService
    {
        public string GenerateAndDownLoadExcel()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseApi<List<T_JOB_REPO>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseApi<List<SP_SEARCH_RC_Result>>> GetAllbySp(SearchModel model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseApi<List<SP_SEARCH_RC_Result>>> GetList(SearchModel model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseApi<FileUploadModel>> Save(List<FileUploadModel> model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveFile(List<FileUploadModel> model)
        {
            throw new NotImplementedException();
        }
    }
}
