using static DemoWebApp.FrontEnd.Models.LoginViewModel;

namespace DemoWebApp.FrontEnd.Services.Interfaces
{
    public interface ICommonService
    {
        SessionInfo GetSessionValue();
    }
}
