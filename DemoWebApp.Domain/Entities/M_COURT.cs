using System;
using System.Collections.Generic;

namespace DemoWebApp.Domain.Entities;

public partial class M_COURT
{
    /// <summary>
    /// รหัสศาล
    /// </summary>
    public string COURT_CODE { get; set; }

    /// <summary>
    /// ชื่อไทย
    /// </summary>
    public string COURT_NAME_TH { get; set; }

    /// <summary>
    /// ชื่ออังกฤษ
    /// </summary>
    public string COURT_NAME_EN { get; set; }

    /// <summary>
    /// ประเภทศาล
    /// </summary>
    public string COURT_TYPE { get; set; }

    /// <summary>
    /// จำนวนค่าธรรมเนียมศาล
    /// </summary>
    public decimal? COURT_AMT { get; set; }

    /// <summary>
    /// ผู้สร้าง
    /// </summary>
    public string COURT_CREATE_BY { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? COURT_CREATE_DATE { get; set; }

    /// <summary>
    /// ผู้แก้ไข
    /// </summary>
    public string COURT_UPDATE_BY { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? COURT_UPDATE_DATE { get; set; }

    /// <summary>
    /// สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน
    /// </summary>
    public string COURT_STATUS { get; set; }
}
