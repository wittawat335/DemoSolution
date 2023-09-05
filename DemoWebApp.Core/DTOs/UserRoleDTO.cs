using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebApp.Core.DTOs
{
    public class UserRoleDTO
    {
        public string USERROLE_USER_LOGIN { get; set; } = null!;
        public string USERROLE_ROLE_CODE { get; set; } = null!;
        public string USERROLE_CREATE_BY { get; set; }
        public DateTime? USERROLE_CREATE_DATE { get; set; }
        public string USERROLE_UPDATE_BY { get; set; }
        public DateTime? USERROLE_UPDATE_DATE { get; set; }
        public string USERROLE_STATUS { get; set; }
    }
}
