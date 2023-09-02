using AutoMapper;
using DemoWebApp.Core.DTOs;
using DemoWebApp.Core.Interfaces;
using DemoWebApp.Core.Models.Master;
using DemoWebApp.Domain.Entities;
using DemoWebApp.Domain.RepositoryContracts;
using Microsoft.VisualBasic;
using System.Collections;
using System.Collections.Generic;

namespace DemoWebApp.Core.Services
{
    public class MasterService : IMasterService
    {
        private readonly IGenericRepository<M_MASTER> _repository;
        private readonly IMapper _mapper;

        public MasterService(IGenericRepository<M_MASTER> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<List<MasterDTO>> Search(SearchModel model)
        {
            throw new NotImplementedException();
        }
        public async Task<List<MasterDTO>> GetAll()
        {
            try
            {
                var list = await _repository.AsQueryable();
                return _mapper.Map<List<MasterDTO>>(list);
            }
            catch
            {
                throw;
            }
        }
        public Task<MasterDTO> GetByCode(string code)
        {
            throw new NotImplementedException();
        }
        public Task<List<MasterDTO>> GetListByMasterType(string code)
        {
            throw new NotImplementedException();
        }
        public Task<List<MasterDTO>> GetListMasterActiveOnly()
        {
            throw new NotImplementedException();
        }
        public void Insert(MasterDTO model)
        {
            throw new NotImplementedException();
        }
        public void Update(MasterDTO model)
        {
            throw new NotImplementedException();
        }
        public void Delete(string code)
        {
            throw new NotImplementedException();
        }
    }
}
