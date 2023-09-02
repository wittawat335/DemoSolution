using System;
using System.Collections.Generic;

namespace DemoWebApp.Domain.Entities;

public partial class T_REPO_NOTE
{
    /// <summary>
    /// รหัส Note
    /// </summary>
    public long NOTE_ID { get; set; }

    /// <summary>
    /// T_JOB_REPO.JOB_ID
    /// </summary>
    public string NOTE_JOB_ID { get; set; }

    /// <summary>
    /// เลขที่สัญญา
    /// </summary>
    public string NOTE_CONTRACT_NO { get; set; }

    /// <summary>
    /// หมายเหตุ
    /// </summary>
    public string NOTE_REMARK { get; set; }

    /// <summary>
    /// ผู้สร้าง
    /// </summary>
    public string NOTE_CREATE_BY { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? NOTE_CREATE_DATE { get; set; }

    /// <summary>
    /// ผู้แก้ไข
    /// </summary>
    public string NOTE_UPDATE_BY { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? NOTE_UPDATE_DATE { get; set; }

    /// <summary>
    /// สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน
    /// </summary>
    public string NOTE_STATUS { get; set; }
}
