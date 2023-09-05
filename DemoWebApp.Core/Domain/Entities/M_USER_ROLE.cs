using System;
using System.Collections.Generic;

namespace DemoWebApp.Core.Domain.Entities;

public partial class M_USER_ROLE
{
    /// <summary>
    /// M_User.User_Login
    /// </summary>
    public string USERROLE_USER_LOGIN { get; set; }

    /// <summary>
    /// M_Role.Role_Code
    /// </summary>
    public string USERROLE_ROLE_CODE { get; set; }

    /// <summary>
    /// ผู้สร้าง
    /// </summary>
    public string USERROLE_CREATE_BY { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? USERROLE_CREATE_DATE { get; set; }

    /// <summary>
    /// ผู้แก้ไข
    /// </summary>
    public string USERROLE_UPDATE_BY { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? USERROLE_UPDATE_DATE { get; set; }

    /// <summary>
    /// สถานะข้อมูล
    /// </summary>
    public string USERROLE_STATUS { get; set; }
}
