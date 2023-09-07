using DemoWebApp.Core.DTOs;
using DemoWebApp.Core.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList()
        {
            return Ok(await _service.GetAll());
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            return Ok(await _service.Login(request));
        }
    }
}
