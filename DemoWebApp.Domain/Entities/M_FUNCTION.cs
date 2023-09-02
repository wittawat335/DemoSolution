using System;
using System.Collections.Generic;

namespace DemoWebApp.Domain.Entities;

public partial class M_FUNCTION
{
    /// <summary>
    /// รหัสฟังชั่น
    /// </summary>
    public string FUNC_CODE { get; set; }

    /// <summary>
    /// M_Program.Prog_Code
    /// </summary>
    public string FUNC_PROG_CODE { get; set; }

    /// <summary>
    /// ชื่อฟังชั่น
    /// </summary>
    public string FUNC_NAME { get; set; }

    /// <summary>
    /// ผู้สร้าง
    /// </summary>
    public string FUNC_CREATE_BY { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? FUNC_CREATE_DATE { get; set; }

    /// <summary>
    /// ผู้แก้ไข
    /// </summary>
    public string FUNC_UPDATE_BY { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? FUNC_UPDATE_DATE { get; set; }

    /// <summary>
    /// สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน
    /// </summary>
    public string FUNC_STATUS { get; set; }
}
