using DemoWebApp.Core.DTOs;
using DemoWebApp.Core.Helper;
using DemoWebApp.Core.Models;
using DemoWebApp.Core.Services.Contracts;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using MimeKit.Text;
using System.Net.Http;
using System.Net.Security;

namespace DemoWebApp.Core.Services
{
    public class EmailService : IEmailService
    {
        private readonly EmailSettings _settings;

        public EmailService(IOptions<EmailSettings> options)
        {
            this._settings = options.Value;
        }

        public string GetHtmlContent()
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

        public void SendEmail(EmailDTO request, string host, string username, string password)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(username));
            email.To.Add(MailboxAddress.Parse(request.To));
            email.Subject = request.Subject;
            email.Body = new TextPart(TextFormat.Html) { Text = request.Body };

            using var smtp = new SmtpClient();
            smtp.Connect(host, 587, SecureSocketOptions.StartTls);
            smtp.Authenticate(username, password);
            smtp.Send(email);
            smtp.Disconnect(true);
        }

        public async Task<ResponseApi<bool>> SendEmailAsync(MailRequest request)
        {
            var response = new ResponseApi<bool>();
            try
            {
                request.ToEmail = "wittawat335@gmail.com";
                request.Subject = "Welcome";
                request.Body = GetHtmlContent();

                var email = new MimeMessage();
                email.Sender = MailboxAddress.Parse(_settings.Email);
                email.To.Add(MailboxAddress.Parse(request.ToEmail));
                email.Subject = request.Subject;
                var builder = new BodyBuilder();

                byte[] fileBytes;
                string fileTarget = @"E:\Project 2023\.Net Core\MVC\DemoSolution\DemoWebApp.Core\Attachment\dummy.pdf";

                if (File.Exists(fileTarget))
                {
                    FileStream file = new FileStream(fileTarget, FileMode.Open, FileAccess.Read);
                    using (var ms = new MemoryStream())
                    {
                        file.CopyTo(ms);
                        fileBytes = ms.ToArray();
                    }
                    builder.Attachments.Add("attachment.pdf", fileBytes, ContentType.Parse("application/octet-stream"));
                    builder.Attachments.Add("attachment2.pdf", fileBytes, ContentType.Parse("application/octet-stream"));
                }

                builder.HtmlBody = request.Body;
                email.Body = builder.ToMessageBody();

                using var smtp = new SmtpClient();
                smtp.Connect(_settings.Host, _settings.Port, SecureSocketOptions.StartTls);
                smtp.Authenticate(_settings.Email, _settings.Password);
                await smtp.SendAsync(email);
                smtp.Disconnect(true);

                response.IsSuccess = true;
                response.Message = "Send E-Mail Successfully";
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
    }
}
