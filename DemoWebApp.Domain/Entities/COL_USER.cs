using System;
using System.Collections.Generic;

namespace DemoWebApp.Domain.Entities;

public partial class COL_USER
{
    /// <summary>
    /// รหัสผู้ใช้
    /// </summary>
    public string USER_CODE { get; set; }

    /// <summary>
    /// รหัสผ่าน
    /// </summary>
    public string USER_PASSWORD { get; set; }

    /// <summary>
    /// ชื่อภาษาอังกฤษ
    /// </summary>
    public string FIRST_NAME_EN { get; set; }

    /// <summary>
    /// ชื่อภาษาไทย
    /// </summary>
    public string FIRST_NAME_TH { get; set; }

    /// <summary>
    /// นาสกุลภาษาอังกฤษ
    /// </summary>
    public string LAST_NAME_EN { get; set; }

    /// <summary>
    /// นามสกุลภาษาไทย
    /// </summary>
    public string LAST_NAME_TH { get; set; }

    /// <summary>
    /// กลุ่มผู้ใช้ Admin,Collector
    /// </summary>
    public string USER_GROUP { get; set; }

    /// <summary>
    /// สถานะผู้ใช้ A = Active ,I = Inactive
    /// </summary>
    public string USER_STATUS { get; set; }

    /// <summary>
    /// จำนวนครั้งที่ Login
    /// </summary>
    public int? LOGIN_COUNTER { get; set; }

    /// <summary>
    /// ผู้สร้าง
    /// </summary>
    public string CREATE_BY { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? CREATE_DATE { get; set; }

    /// <summary>
    /// ผู้แก้ไข
    /// </summary>
    public string UPDATE_BY { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? UPDATE_DATE { get; set; }
}
