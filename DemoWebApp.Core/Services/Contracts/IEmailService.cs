using DemoWebApp.Core.DTOs;
using DemoWebApp.Core.Helper;
using DemoWebApp.Core.Models;

namespace DemoWebApp.Core.Services.Contracts
{
    public interface IEmailService
    {
        void SendEmail(EmailDTO request, string host, string username, string password);
        Task<ResponseApi<bool>> SendEmailAsync(MailRequest request);
        string GetHtmlContent();
    }
}
