using System;
using System.Collections.Generic;

namespace DemoWebApp.Core.Domain.Entities;

public partial class M_STATUS
{
    /// <summary>
    /// รหัสสถานะ
    /// </summary>
    public string STS_CODE { get; set; }

    /// <summary>
    /// ชื่อไทย
    /// </summary>
    public string STS_NAME_TH { get; set; }

    /// <summary>
    /// ชื่ออังกฤษ
    /// </summary>
    public string STS_NAME_EN { get; set; }

    /// <summary>
    /// ผู้สร้าง
    /// </summary>
    public string STS_CREATE_BY { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? STS_CREATE_DATE { get; set; }

    /// <summary>
    /// ผู้แก้ไข
    /// </summary>
    public string STS_UPDATE_BY { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? STS_UPDATE_DATE { get; set; }

    /// <summary>
    /// สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน
    /// </summary>
    public string STS_STATUS { get; set; }
}
