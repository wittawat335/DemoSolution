using System;
using System.Collections.Generic;

namespace DemoWebApp.Domain.Entities;

public partial class M_OA
{
    /// <summary>
    /// รหัส OA
    /// </summary>
    public string OA_CODE { get; set; }

    /// <summary>
    /// ชื่อไทย
    /// </summary>
    public string OA_NAME_TH { get; set; }

    /// <summary>
    /// ชื่ออังกฤษ
    /// </summary>
    public string OA_NAME_EN { get; set; }

    /// <summary>
    /// M_OutsourceGroup.OutsGroup_Code
    /// </summary>
    public string OA_GROUP_CODE { get; set; }

    public string OA_REPO_FLAG { get; set; }

    public string OA_LEGAL_FLAG { get; set; }

    public string OA_TYPE { get; set; }

    /// <summary>
    /// ผู้สร้าง
    /// </summary>
    public string OA_CREATE_BY { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? OA_CREATE_DATE { get; set; }

    /// <summary>
    /// ผู้แก้ไข
    /// </summary>
    public string OA_UPDATE_BY { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? OA_UPDATE_DATE { get; set; }

    /// <summary>
    /// สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน
    /// </summary>
    public string OA_STATUS { get; set; }
}
