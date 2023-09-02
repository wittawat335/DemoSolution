using System;
using System.Collections.Generic;

namespace DemoWebApp.Domain.Entities;

public partial class M_ACTION
{
    /// <summary>
    /// รหัสแอคชั่น
    /// </summary>
    public string ACT_CODE { get; set; }

    /// <summary>
    /// M_Function.Func_Code
    /// </summary>
    public string ACT_PROG_CODE { get; set; }

    /// <summary>
    /// ชื่อแอคชั่น
    /// </summary>
    public string ACT_NAME { get; set; }

    /// <summary>
    /// ผู้สร้าง
    /// </summary>
    public string ACT_CREATE_BY { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? ACT_CREATE_DATE { get; set; }

    /// <summary>
    /// ผู้ที่แก้ไข
    /// </summary>
    public string ACT_UPDATE_BY { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? ACT_UPDATE_DATE { get; set; }

    /// <summary>
    /// สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน
    /// </summary>
    public string ACT_STATUS { get; set; }
}
