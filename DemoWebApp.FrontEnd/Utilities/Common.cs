using Newtonsoft.Json;
using static DemoWebApp.FrontEnd.Models.LoginViewModel;

namespace DemoWebApp.FrontEnd.Utilities
{
    public class Common
    {
        IHttpContextAccessor _contextAccessor = new HttpContextAccessor();
        public LoginInfo GetValueBySession()
        {
            var session = new LoginInfo();
            string sessionString = _contextAccessor.HttpContext.Session.GetString(Constants.SessionKey.sessionLogin);

            if (sessionString != null)
                session = JsonConvert.DeserializeObject<LoginInfo>(sessionString);

            return session;
        }

        public class ddlValue
        {
            public string CODE { get; set; }
            public string TEXT { get; set; }
        }

    }
}
