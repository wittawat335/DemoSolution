using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebApp.Core.DTOs
{
    public class LoginResponse
    {
        public long clID { get; set; }
        public string userLogin { get; set; }
        public string fullName { get; set; }
        public string role { get; set; }
        public string roleName { get; set; }
        public string dataLevel { get; set; }
        public string accessToken { get; set; } = string.Empty;
    }
}
