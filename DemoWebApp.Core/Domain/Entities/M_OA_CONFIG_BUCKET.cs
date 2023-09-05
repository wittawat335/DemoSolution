using System;
using System.Collections.Generic;

namespace DemoWebApp.Core.Domain.Entities;

public partial class M_OA_CONFIG_BUCKET
{
    /// <summary>
    /// M_OA.OA_CODE
    /// </summary>
    public string MOB_OA_CODE { get; set; }

    /// <summary>
    /// M_PROVINCE.Province_Id
    /// </summary>
    public string MOB_BUCKET_CODE { get; set; }

    /// <summary>
    /// จำนวนเปอร์เซนต์สูงสุด
    /// </summary>
    public int? MOB_LIMIT_PERCENTAGE { get; set; }

    /// <summary>
    /// จำนวนงานสูงสุด
    /// </summary>
    public int? MOB_LIMIT_JOBS { get; set; }

    /// <summary>
    /// ผู้สร้าง
    /// </summary>
    public string MOB_CREATE_BY { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? MOB_CREATE_DATE { get; set; }

    /// <summary>
    /// ผู้แก้ไข
    /// </summary>
    public string MOB_UPDATE_BY { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? MOB_UPDATE_DATE { get; set; }

    /// <summary>
    /// สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน
    /// </summary>
    public string MOB_STATUS { get; set; }
}
