using System;
using System.Collections.Generic;

namespace DemoWebApp.Domain.Entities;

public partial class M_PROVINCE
{
    /// <summary>
    /// รหัสจังหวัด
    /// </summary>
    public string PROVINCE_CODE { get; set; }

    /// <summary>
    /// ชื่อจังหวัด
    /// </summary>
    public string PROVINCE_NAME { get; set; }

    /// <summary>
    /// รหัสภูมิศาสตร์
    /// </summary>
    public string PROVINCE_GEOGRAPHYCODE { get; set; }

    public int? PROVINCE_KM { get; set; }

    /// <summary>
    /// ผู้สร้าง
    /// </summary>
    public string PROVINCE_CREATEBY { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? PROVINCE_CREATEDATE { get; set; }

    /// <summary>
    /// ผู้แก้ไข
    /// </summary>
    public string PROVINCE_UPDATEBY { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? PROVINCE_UPDATEDATE { get; set; }

    /// <summary>
    /// สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน
    /// </summary>
    public string PROVINCE_STATUS { get; set; }
}
