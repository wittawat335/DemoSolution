using System;
using System.Collections.Generic;

namespace DemoWebApp.Core.Domain.Entities;

public partial class M_LEGAL_STATUS
{
    /// <summary>
    /// CaseLegal ผูกกับ สถานะ M_Master.Master_Code [MasterInfoType=LCTP]
    /// </summary>
    public string LGSTS_CASE_CODE { get; set; }

    /// <summary>
    /// M_Status.Sts_Code
    /// </summary>
    public string LGSTS_STS_CODE { get; set; }

    /// <summary>
    /// สถานะ สำเร็จ
    /// </summary>
    public string LGSTS_SUCC_FLAG { get; set; }

    /// <summary>
    /// จำนวนเริ่มต้น 1
    /// </summary>
    public int? LGSTS_START_1 { get; set; }

    /// <summary>
    /// จำนวนสิ้นสุด 1
    /// </summary>
    public int? LGSTS_END_1 { get; set; }

    /// <summary>
    /// รหัสสี 1
    /// </summary>
    public string LGSTS_COLOR_1 { get; set; }

    /// <summary>
    /// จำนวนเริ่มต้น 2
    /// </summary>
    public int? LGSTS_START_2 { get; set; }

    /// <summary>
    /// จำนวนสิ้นสุด 2
    /// </summary>
    public int? LGSTS_END_2 { get; set; }

    /// <summary>
    /// รหัสสี 2
    /// </summary>
    public string LGSTS_COLOR_2 { get; set; }

    /// <summary>
    /// จำนวนเริ่มต้น 3
    /// </summary>
    public int? LGSTS_START_3 { get; set; }

    /// <summary>
    /// จำนวนสิ้นสุด 3
    /// </summary>
    public int? LGSTS_END_3 { get; set; }

    /// <summary>
    /// รหัสสี 3
    /// </summary>
    public string LGSTS_COLOR_3 { get; set; }

    /// <summary>
    /// จำนวนเริ่มต้น 4
    /// </summary>
    public int? LGSTS_START_4 { get; set; }

    /// <summary>
    /// จำนวนสิ้นสุด 4
    /// </summary>
    public int? LGSTS_END_4 { get; set; }

    /// <summary>
    /// รหัสสี 4
    /// </summary>
    public string LGSTS_COLOR_4 { get; set; }

    /// <summary>
    /// จำนวนเริ่มต้น 5
    /// </summary>
    public int? LGSTS_START_5 { get; set; }

    /// <summary>
    /// จำนวนสิ้นสุด 5
    /// </summary>
    public int? LGSTS_END_5 { get; set; }

    /// <summary>
    /// รหัสสี 5
    /// </summary>
    public string LGSTS_COLOR_5 { get; set; }

    /// <summary>
    /// ผู้สร้าง
    /// </summary>
    public string LGSTS_CREATE_BY { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? LGSTS_CREATE_DATE { get; set; }

    /// <summary>
    /// ผู้แก้ไข
    /// </summary>
    public string LGSTS_UPDATE_BY { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? LGSTS_UPDATE_DATE { get; set; }

    /// <summary>
    /// สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน
    /// </summary>
    public string LGSTS_STATUS { get; set; }
}
