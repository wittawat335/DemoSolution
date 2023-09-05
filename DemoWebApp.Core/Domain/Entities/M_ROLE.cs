using System;
using System.Collections.Generic;

namespace DemoWebApp.Core.Domain.Entities;

public partial class M_ROLE
{
    /// <summary>
    /// รหัสสิทธิ์
    /// </summary>
    public string ROLE_CODE { get; set; }

    /// <summary>
    /// ชื่อสิทธิ์
    /// </summary>
    public string ROLE_NAME { get; set; }

    /// <summary>
    /// ระดับการเข้าถึงข้อมูล
    /// </summary>
    public int ROLE_DATA_LEVEL { get; set; }

    /// <summary>
    /// ผู้สร้าง
    /// </summary>
    public string ROLE_CREATE_BY { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? ROLE_CREATE_DATE { get; set; }

    /// <summary>
    /// ผู้แก้ไข
    /// </summary>
    public string ROLE_UPDATE_BY { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? ROLE_UPDATE_DATE { get; set; }

    /// <summary>
    /// สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน
    /// </summary>
    public string ROLE_STATUS { get; set; }
}
