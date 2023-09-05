using DemoWebApp.Core.DTOs;
using DemoWebApp.Core.Helper;
using DemoWebApp.Core.Services.Contracts;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;

namespace DemoWebApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestSendEmailController : ControllerBase
    {
        private readonly IEmailService _service;
        private readonly IConfiguration _config;

        public TestSendEmailController(IEmailService service, IConfiguration config)
        {
            _service = service;
            _config = config;
        }

        [HttpPost]
        public IActionResult SendEmail(EmailDTO request)
        {
            var host = _config["AppSetting:Email:Host"];
            var username = _config["AppSetting:Email:UserName"];
            var password = _config["AppSetting:Email:Password"];
            _service.SendEmail(request, host, username, password);
            return Ok();
        }

        [HttpPost("SendEmailAsync")]
        public async Task<IActionResult> SendEmailAsync(MailRequest request)
        {
            await _service.SendEmailAsync(request);
            return Ok();
        }
    }
}
