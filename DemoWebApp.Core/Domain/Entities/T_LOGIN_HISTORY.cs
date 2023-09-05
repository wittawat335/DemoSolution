using System;
using System.Collections.Generic;

namespace DemoWebApp.Core.Domain.Entities;

public partial class T_LOGIN_HISTORY
{
    /// <summary>
    /// รหัส login
    /// </summary>
    public long CL_ID { get; set; }

    /// <summary>
    /// User Login
    /// </summary>
    public string CL_USER_LOGIN { get; set; }

    /// <summary>
    /// รหัส Role
    /// </summary>
    public string CL_ROLE_CODE { get; set; }

    /// <summary>
    /// ip address
    /// </summary>
    public string CL_IP_ADDRESS { get; set; }

    /// <summary>
    /// วันที่ Login
    /// </summary>
    public DateTime? CL_LOGIN_DATE { get; set; }

    /// <summary>
    /// ครั้งสุดท้ายที่ใช้งาน
    /// </summary>
    public DateTime? CL_LAST_ACT_DATE { get; set; }

    /// <summary>
    /// สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน
    /// </summary>
    public string CL_STATUS { get; set; }
}
