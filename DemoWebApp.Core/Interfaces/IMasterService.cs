using DemoWebApp.Core.DTOs;
using DemoWebApp.Core.Models.Master;
using System;
using System.Collections.Generic;
namespace DemoWebApp.Core.Interfaces
{
    public interface IMasterService
    {
        Task<List<MasterDTO>> GetAll();
        Task<List<MasterDTO>> Search(SearchModel model);
        Task<List<MasterDTO>> GetListByMasterType(string code);
        Task<List<MasterDTO>> GetListMasterActiveOnly();
        Task<MasterDTO> GetByCode(string code);
        void Insert(MasterDTO model);
        void Update(MasterDTO model);
        void Delete(string code);
    }
}
