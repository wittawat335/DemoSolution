using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebApp.Core.DTOs
{
    public class CurrentLoginDTO
    {
        public long CL_ID { get; set; }

        /// <summary>
        /// M_User.User_Login
        /// </summary>
        public string CL_USER_LOGIN { get; set; }

        /// <summary>
        /// M_Role.Role_Code
        /// </summary>
        public string CL_ROLE_CODE { get; set; }

        /// <summary>
        /// ไอพี
        /// </summary>
        public string CL_IP_ADDRESS { get; set; }

        /// <summary>
        /// วันที่เข้าระบบ
        /// </summary>
        public DateTime? CL_LOGIN_DATE { get; set; }

        /// <summary>
        /// วันที่เข้าใช้งานล่าสุด
        /// </summary>
        public DateTime? CL_LAST_ACT_DATE { get; set; }

        /// <summary>
        /// สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน
        /// </summary>
        public string CL_STATUS { get; set; }

        public string CL_COMP_CODE { get; set; }

        public string CL_BRANCH_CODE { get; set; }
    }
}
