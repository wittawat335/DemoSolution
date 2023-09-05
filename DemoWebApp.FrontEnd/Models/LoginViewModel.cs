namespace DemoWebApp.FrontEnd.Models
{
    public class LoginViewModel
    {
        public string UserLogin { get; set; }
        public string Password { get; set; }

        public class LoginInfo
        {
            public string AccessToken { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
            public string Password { get; set; } = string.Empty;
            public string UserId { get; set; } = string.Empty;
            public string UserName { get; set; } = string.Empty;
            public string FullName { get; set; }
            public string RoleName { get; set; }
        }
    }
}
