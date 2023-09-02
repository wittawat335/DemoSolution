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
            var response = await _service.GetAll();
            return Ok(response);
        }

        [HttpPost]
        public IActionResult Insert(MasterDTO model)
        {
            var response = _service.Insert(model);
            return Ok(response);
        }
    }
}
