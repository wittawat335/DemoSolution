
namespace DemoWebApp.Core.Services.Contracts
{
    public interface IPermissionService
    {
        Task<bool> GetPermission(string userRole, string programCode, string actCode);
    }
}
