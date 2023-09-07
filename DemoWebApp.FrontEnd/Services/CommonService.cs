using DemoWebApp.FrontEnd.Services.Interfaces;
using DemoWebApp.FrontEnd.Utilities;
using Newtonsoft.Json;
using static DemoWebApp.FrontEnd.Models.LoginViewModel;

namespace DemoWebApp.FrontEnd.Services
{
    public class CommonService : ICommonService
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public CommonService(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public SessionInfo GetSessionValue()
        {
            var session = new SessionInfo();
            string sessionString = _contextAccessor.HttpContext.Session.GetString(Constants.SessionKey.sessionLogin);

            if (sessionString != null)
                session = JsonConvert.DeserializeObject<SessionInfo>(sessionString);

            return session;
        }
    }
}
