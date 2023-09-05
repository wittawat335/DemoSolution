using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebApp.Core.DTOs
{
    public class RoleDTO
    {
        public string ROLE_CODE { get; set; } = null!;
        public string ROLE_NAME { get; set; } = null!;
        public int ROLE_DATA_LEVEL { get; set; }
        public string ROLE_CREATE_BY { get; set; }
        public DateTime ROLE_CREATE_DATE { get; set; }
        public string ROLE_UPDATE_BY { get; set; }
        public DateTime ROLE_UPDATE_DATE { get; set; }
        public string ROLE_STATUS { get; set; }
    }
}
