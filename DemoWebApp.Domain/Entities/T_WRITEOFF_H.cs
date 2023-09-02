using System;
using System.Collections.Generic;

namespace DemoWebApp.Domain.Entities;

public partial class T_WRITEOFF_H
{
    /// <summary>
    /// รหัสเอกสาร
    /// </summary>
    public string WRITEOFF_DOC_ID { get; set; }

    /// <summary>
    /// วันที่ Generate เอกสาร
    /// </summary>
    public DateTime? WRITEOFF_DATE { get; set; }

    /// <summary>
    /// ประเภท write-off
    /// </summary>
    public string WRITEOFF_TYPE { get; set; }

    /// <summary>
    /// subtype
    /// </summary>
    public string WRITEOFF_SUBTYPE { get; set; }

    /// <summary>
    /// สถานะการอนุมัติ W=Pending, A=Approved, R=Rejected
    /// </summary>
    public string WRITEOFF_APPROVE_FLAG { get; set; }

    /// <summary>
    /// ผู้อนุมัติ
    /// </summary>
    public string WRITEOFF_APPROVE_BY { get; set; }

    /// <summary>
    /// วันที่อนุมัติ
    /// </summary>
    public DateTime? WRITEOFF_APPROVE_DATE { get; set; }

    /// <summary>
    /// ผู้สร้าง
    /// </summary>
    public string WRITEOFF_CREATE_BY { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? WRITEOFF_CREATE_DATE { get; set; }

    /// <summary>
    /// ผู้ที่แก้ไข
    /// </summary>
    public string WRITEOFF_UPDATE_BY { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? WRITEOFF_UPDATE_DATE { get; set; }

    /// <summary>
    /// สถานะใช้งาน A=Active,I=Inactive
    /// </summary>
    public string WRITEOFF_STATUS { get; set; }
}
