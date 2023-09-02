using System;
using System.Collections.Generic;

namespace DemoWebApp.Domain.Entities;

public partial class M_BUCKET
{
    /// <summary>
    /// รหัสระดับการติดตาม (Bucket)
    /// </summary>
    public string BUCKET_CODE { get; set; }

    /// <summary>
    /// ชื่อระดับการติดตาม (Bucket)
    /// </summary>
    public string BUCKET_NAME { get; set; }

    /// <summary>
    /// รายละเอียดระดับการติดตาม (Bucket)
    /// </summary>
    public string BUCKET_DESC { get; set; }

    /// <summary>
    /// จำนวนวันค้างชำระสิ้นสุด
    /// </summary>
    public int? BUCKET_OVDDAYS_START { get; set; }

    /// <summary>
    /// จำนวนวันค้างชำระสิ้นสุด
    /// </summary>
    public int? BUCKET_OVDDAYS_END { get; set; }

    /// <summary>
    /// ผู้สร้าง
    /// </summary>
    public string BUCKET_CREATE_BY { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? BUCKET_CREATE_DATE { get; set; }

    /// <summary>
    /// ผู้แก้ไข
    /// </summary>
    public string BUCKET_UPDATE_BY { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? BUCKET_UPDATE_DATE { get; set; }

    /// <summary>
    /// สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน
    /// </summary>
    public string BUCKET_STATUS { get; set; }

    public string BUCKET_COMP_CODE { get; set; }

    public string BUCKET_BRANCH_CODE { get; set; }
}
