using System;
using System.Collections.Generic;

namespace DemoWebApp.Domain.Entities;

public partial class M_DOCUMENT
{
    /// <summary>
    /// M_Master.Master_Code [MasterInfoType=LCTP]
    /// </summary>
    public string DOC_CASE_CODE { get; set; }

    /// <summary>
    /// M_Master.Master_Code [MasterInfoType=DOTP]
    /// </summary>
    public string DOC_CODE { get; set; }

    /// <summary>
    /// สถานะ
    /// </summary>
    public string DOC_REQ_FLAG { get; set; }

    /// <summary>
    /// ผู้สร้าง
    /// </summary>
    public string DOC_CREATE_BY { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? DOC_CREATE_DATE { get; set; }

    /// <summary>
    /// ผู้แก้ไข
    /// </summary>
    public string DOC_UPDATE_BY { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? DOC_UPDATE_DATE { get; set; }

    /// <summary>
    /// สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน
    /// </summary>
    public string DOC_STATUS { get; set; }
}
