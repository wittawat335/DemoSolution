using DemoWebApp.Core.DTOs;
using DemoWebApp.Core.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        private readonly IMasterService _service;
        public MasterController(IMasterService service)
        {
            _service = service;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAll());
        }

        [HttpGet("GetListByMasterType/{code}")]
        public async Task<IActionResult> GetListByMasterType(string code)
        {
            return Ok(await _service.GetListByMasterType(code));
        }

        [HttpGet("GetListMasterActiveOnly")]
        public async Task<IActionResult> GetListMasterActiveOnly()
        {
            return Ok(await _service.GetListMasterActiveOnly());
        }

        [HttpGet("GetByCode/{code}")]
        public async Task<IActionResult> GetByCode(string code)
        {
            return Ok(await _service.GetByCode(code));
        }

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert(MasterDTO model)
        {
            return Ok(await _service.Insert(model));
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(MasterDTO model)
        {
            return Ok(await _service.Update(model));
        }

        [HttpDelete("Delete/{code}")]
        public async Task<IActionResult> Delete(string code)
        {
            return Ok(await _service.Delete(code));
        }
    }
}
