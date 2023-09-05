using System;
using System.Collections.Generic;

namespace DemoWebApp.Core.Domain.Entities;

public partial class M_OA_GROUP
{
    /// <summary>
    /// รหัสกลุ่ม OA
    /// </summary>
    public string OAGROUP_CODE { get; set; }

    /// <summary>
    /// ชื่อไทย
    /// </summary>
    public string OAGROUP_NAME_TH { get; set; }

    /// <summary>
    /// ชื่ออังกฤษ
    /// </summary>
    public string OAGROUP_NAME_EN { get; set; }

    /// <summary>
    /// วันหมดอายุ
    /// </summary>
    public int? OAGROUP_EXPIRED_DAY { get; set; }

    /// <summary>
    /// ผู้สร้าง
    /// </summary>
    public string OAGROUP_CREATE_BY { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? OAGROUP_CREATE_DATE { get; set; }

    /// <summary>
    /// ผู้แก้ไข
    /// </summary>
    public string OAGROUP_UPDATE_BY { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? OAGROUP_UPDATE_DATE { get; set; }

    /// <summary>
    /// สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน
    /// </summary>
    public string OAGROUP_STATUS { get; set; }
}
