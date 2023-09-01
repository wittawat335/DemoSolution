namespace DemoWebApp.Web.Models
{
    public class LoginViewModel
    {
        public string UserLogin { get; set; }
        public string Password { get; set; }

        public class LoginInfo
        {
            public long clID { get; set; }
            public string UserLogin { get; set; }
            public string FullName { get; set; }
            public string Role { get; set; }
            public string RoleName { get; set; }
            public string DataLevel { get; set; }
        }
    }
}
