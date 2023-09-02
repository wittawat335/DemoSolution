using System;
using System.Collections.Generic;

namespace DemoWebApp.Domain.Entities;

public partial class M_LEGAL_CASE
{
    /// <summary>
    /// รหัส Case
    /// </summary>
    public string CASE_CODE { get; set; }

    /// <summary>
    /// ชื่อกรณีทางกฎหมาย ภาษาไทย
    /// </summary>
    public string CASE_NAME_TH { get; set; }

    /// <summary>
    /// ชื่อกรณีทางกฎหมาย ภาษาอังกฤษ
    /// </summary>
    public string CASE_NAME_EN { get; set; }

    /// <summary>
    /// รหัสประเภทกลุ่มคดี
    /// </summary>
    public string CASE_GROUP_CODE { get; set; }

    /// <summary>
    /// ประเภทการฟ้อง [Contract, Cheque]
    /// </summary>
    public string CASE_TYPE { get; set; }

    /// <summary>
    /// รหัสสี
    /// </summary>
    public string CASE_COLOR { get; set; }

    /// <summary>
    /// สถานะเอกสาร
    /// </summary>
    public string CASE_DOC_FLAG { get; set; }

    /// <summary>
    /// ที่เก็บข้อมูล
    /// </summary>
    public string CASE_TABLE { get; set; }

    /// <summary>
    /// ลำดับ
    /// </summary>
    public int? CASE_SEQ { get; set; }

    /// <summary>
    /// ผู้สร้าง
    /// </summary>
    public string CASE_CREATE_BY { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? CASE_CREATE_DATE { get; set; }

    /// <summary>
    /// ผู้แก้ไข
    /// </summary>
    public string CASE_UPDATE_BY { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? CASE_UPDATE_DATE { get; set; }

    /// <summary>
    /// สถานะข้อมูล A=Active,I=Inactive
    /// </summary>
    public string CASE_STATUS { get; set; }
}
