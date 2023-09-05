using DemoWebApp.Core.DTOs;
using DemoWebApp.Core.Helper;

namespace DemoWebApp.Core.Services.Contracts
{
    public interface IEmailService
    {
        void SendEmail(EmailDTO request, string host, string username, string password);
        Task SendEmailAsync(MailRequest request);
    }
}
