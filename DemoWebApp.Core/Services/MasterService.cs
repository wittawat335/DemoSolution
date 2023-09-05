using AutoMapper;
using DemoWebApp.Core.DTOs;
using DemoWebApp.Core.Models;
using DemoWebApp.Core.Models.Master;
using DemoWebApp.Core.Services.Contracts;
using DemoWebApp.Core.Utilities;
using DemoWebApp.Core.Domain.Entities;
using DemoWebApp.Core.Domain.RepositoryContracts;

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
        public async Task<ResponseApi<List<MasterDTO>>> GetAll(SearchModel model)
        {
            var response = new ResponseApi<List<MasterDTO>>();
            try
            {
                var list = await _repository.GetListAsync();
                if (model != null)
                {
                    if (model.masterCode != null)
                        list = list.Where(x => x.MASTER_CODE.Contains(model.masterCode)).ToList();
                    if (model.masterType != null)
                        list = list.Where(x => x.MASTER_TYPE.Contains(model.masterType)).ToList();
                    if (model.MasterNameTH != null)
                        list = list.Where(x => x.MASTER_NAME_TH.Contains(model.MasterNameTH)).ToList();
                    if (model.MasterNameEN != null)
                        list = list.Where(x => x.MASTER_NAME_EN.Contains(model.MasterNameEN)).ToList();
                    if (model.masterStatus != null)
                        list = list.Where(x => x.MASTER_STATUS.Contains(model.masterStatus)).ToList();
                }

                response.Value = _mapper.Map<List<MasterDTO>>(list);
                response.IsSuccess = Constants.IsSuccess.True;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }
        public async Task<ResponseApi<MasterDTO>> GetByCode(string code)
        {
            var response = new ResponseApi<MasterDTO>();
            try
            {
                var list = await _repository.GetAsync(x => x.MASTER_CODE == code);
                response.Value = _mapper.Map<MasterDTO>(list);
                response.IsSuccess = Constants.IsSuccess.True;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }
        public async Task<ResponseApi<List<MasterDTO>>> GetListByMasterType(string code)
        {
            var response = new ResponseApi<List<MasterDTO>>();
            try
            {
                var list = await _repository.GetListAsync(x => x.MASTER_TYPE == code);
                response.Value = _mapper.Map<List<MasterDTO>>(list);
                response.IsSuccess = Constants.IsSuccess.True;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }
        public async Task<ResponseApi<List<MasterDTO>>> GetListMasterActiveOnly()
        {
            var response = new ResponseApi<List<MasterDTO>>();
            try
            {
                var list = await _repository.GetListAsync(x => x.MASTER_STATUS == "A");
                list = list.GroupBy(x => x.MASTER_TYPE).Select(x => x.FirstOrDefault()).ToList();
                response.Value = _mapper.Map<List<MasterDTO>>(list);
                response.IsSuccess = Constants.IsSuccess.True;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }
        public async Task<ResponseApi<MasterDTO>> Insert(MasterDTO model)
        {
            var response = new ResponseApi<MasterDTO>();
            try
            {
                _repository.Insert(_mapper.Map<M_MASTER>(model));
                await _repository.SaveChangesAsync();
                response.IsSuccess = Constants.IsSuccess.True;
                response.Message = Constants.StatusMessage.InsertSuccess;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }
        public async Task<ResponseApi<MasterDTO>> Update(MasterDTO model)
        {
            var response = new ResponseApi<MasterDTO>();
            try
            {
                var data = _repository.Find(model.MASTER_CODE);
                if (data != null)
                {
                    _repository.Update(_mapper.Map(model, data));
                    await _repository.SaveChangesAsync();
                    response.IsSuccess = Constants.IsSuccess.True;
                    response.Message = Constants.StatusMessage.UpdateSuccess;
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }
        public async Task<ResponseApi<MasterDTO>> Delete(string code)
        {
            var response = new ResponseApi<MasterDTO>();
            try
            {
                var data = _repository.Find(code);
                if (data != null)
                {
                    _repository.Delete(data);
                    await _repository.SaveChangesAsync();
                    response.IsSuccess = Constants.IsSuccess.True;
                    response.Message = Constants.StatusMessage.DeleteSuccess;
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }
    }
}
