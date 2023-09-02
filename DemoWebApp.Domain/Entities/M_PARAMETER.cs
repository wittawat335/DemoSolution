using System;
using System.Collections.Generic;

namespace DemoWebApp.Domain.Entities;

public partial class M_PARAMETER
{
    /// <summary>
    /// รหัส
    /// </summary>
    public string PARA_CODE { get; set; }

    /// <summary>
    /// ชื่อ
    /// </summary>
    public string PARA_NAME { get; set; }

    /// <summary>
    /// คำอธิบาย Parameter
    /// </summary>
    public string PARA_DESC { get; set; }

    /// <summary>
    /// ประเภทข้อมูล
    /// </summary>
    public string PARA_DATA_TYPE { get; set; }

    /// <summary>
    /// ค่า
    /// </summary>
    public string PARA_VALUE { get; set; }

    /// <summary>
    /// ค่าเริ่มต้น
    /// </summary>
    public string PARA_DEFAULT_VALUE { get; set; }

    /// <summary>
    /// ผู้สร้าง
    /// </summary>
    public string PARA_CREATE_BY { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? PARA_CREATE_DATE { get; set; }

    /// <summary>
    /// ผู้แก้ไข
    /// </summary>
    public string PARA_UPDATE_BY { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? PARA_UPDATE_DATE { get; set; }

    /// <summary>
    /// สถานะข้อมูล
    /// </summary>
    public string PARA_STATUS { get; set; }
}
