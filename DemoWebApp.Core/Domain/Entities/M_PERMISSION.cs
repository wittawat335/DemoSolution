using System;
using System.Collections.Generic;

namespace DemoWebApp.Core.Domain.Entities;

public partial class M_PERMISSION
{
    /// <summary>
    /// M_Role.Role_Code
    /// </summary>
    public string PERM_ROLE_CODE { get; set; }

    /// <summary>
    /// M_Program.Prog_Code
    /// </summary>
    public string PERM_PROG_CODE { get; set; }

    /// <summary>
    /// M_Action.Act_Code
    /// </summary>
    public string PERM_ACT_CODE { get; set; }

    /// <summary>
    /// Default 1
    /// </summary>
    public string PERM_USE_FLAG { get; set; }

    /// <summary>
    /// ผู้สร้าง
    /// </summary>
    public string PERM_CREATE_BY { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? PERM_CREATE_DATE { get; set; }

    /// <summary>
    /// ผู้แก้ไข
    /// </summary>
    public string PERM_UPDATE_BY { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? PERM_UPDATE_DATE { get; set; }

    /// <summary>
    /// สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน
    /// </summary>
    public string PERM_STATUS { get; set; }
}
