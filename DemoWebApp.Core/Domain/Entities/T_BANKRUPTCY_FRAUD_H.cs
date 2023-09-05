using System;
using System.Collections.Generic;

namespace DemoWebApp.Core.Domain.Entities;

public partial class T_BANKRUPTCY_FRAUD_H
{
    /// <summary>
    /// รหัส Doc
    /// </summary>
    public string BF_DOC_ID { get; set; }

    /// <summary>
    /// วันที่ Import file
    /// </summary>
    public DateTime? BF_DATE { get; set; }

    /// <summary>
    /// ประเภท B=Bankruptcy, F=Fraud
    /// </summary>
    public string BF_TYPE { get; set; }

    /// <summary>
    /// สถานะการอนุมัติ W=Pending, A=Approved, R=Rejected
    /// </summary>
    public string BF_APPROVE_FLAG { get; set; }

    /// <summary>
    /// ผู้อนุมัติ
    /// </summary>
    public string BF_APPROVE_BY { get; set; }

    /// <summary>
    /// วีนที่อนุมัติ
    /// </summary>
    public DateTime? BF_APPROVE_DATE { get; set; }

    /// <summary>
    /// ผู้สร้าง
    /// </summary>
    public string BF_CREATE_BY { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? BF_CREATE_DATE { get; set; }

    /// <summary>
    /// ผู้แก้ไข
    /// </summary>
    public string BF_UPDATE_BY { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? BF_UPDATE_DATE { get; set; }

    /// <summary>
    /// สถานะใช้งาน A=Active,I=Inactive
    /// </summary>
    public string BF_STATUS { get; set; }
}
