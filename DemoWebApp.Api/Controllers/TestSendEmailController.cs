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
            request.ToEmail = "wittawat335@gmail.com";
            request.Subject = "Welcome";
            request.Body = GetHtmlcontent();
            await _service.SendEmailAsync(request);
            return Ok();
        }

        private string GetHtmlcontent()
        {
            string Response = "<div style=\"width:100%;background-color:lightblue;text-align:center;margin:10px\">";
            Response += "<h1>Welcome</h1>";
            Response += "<img src=\"https://yt3.googleusercontent.com/v5hyLB4am6E0GZ3y-JXVCxT9g8157eSeNggTZKkWRSfq_B12sCCiZmRhZ4JmRop-nMA18D2IPw=s176-c-k-c0x00ffffff-no-rj\" />";
            Response += "<h2>Thanks for subscribed us</h2>";
            Response += "<a href=\"https://www.youtube.com/channel/UCsbmVmB_or8sVLLEq4XhE_A/join\">Please join membership by click the link</a>";
            Response += "<div><h1> Contact us : wittawa335@gmail.com</h1></div>";
            Response += "</div>";
            return Response;
        }
    }
}
