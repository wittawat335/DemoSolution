using DemoWebApp.Core.Helper;
using DemoWebApp.Core.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendEmailController : ControllerBase
    {
        private readonly IEmailService _service;

        public SendEmailController(IEmailService service)
        {
            _service = service;
        }

        [HttpPost("SendEmailAsync")]
        public async Task<IActionResult> SendEmailAsync(MailRequest request)
        {
            return Ok(await _service.SendEmailAsync(request));
        }
    }
}
