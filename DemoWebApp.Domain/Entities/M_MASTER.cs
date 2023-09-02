using System;
using System.Collections.Generic;

namespace DemoWebApp.Domain.Entities;

public partial class M_MASTER
{
    /// <summary>
    /// รหัส
    /// </summary>
    public string MASTER_CODE { get; set; }

    /// <summary>
    /// ประเภท
    /// </summary>
    public string MASTER_TYPE { get; set; }

    /// <summary>
    /// ชื่อไทย
    /// </summary>
    public string MASTER_NAME_TH { get; set; }

    /// <summary>
    /// ชื่ออังกฤษ
    /// </summary>
    public string MASTER_NAME_EN { get; set; }

    /// <summary>
    /// ผู้สร้าง
    /// </summary>
    public string MASTER_CREATE_BY { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? MASTER_CREATE_DATE { get; set; }

    /// <summary>
    /// ผู้แก้ไข
    /// </summary>
    public string MASTER_UPDATE_BY { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? MASTER_UPDATE_DATE { get; set; }

    /// <summary>
    /// สถานะ
    /// </summary>
    public string MASTER_STATUS { get; set; }
}
