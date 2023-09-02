using System;
using System.Collections.Generic;

namespace DemoWebApp.Domain.Entities;

public partial class COL_USER_CONTRACT
{
    /// <summary>
    /// COL_USER.USER_CODE
    /// </summary>
    public string USER_CODE { get; set; }

    /// <summary>
    /// S_CONTRACT_DETAIL.CONTRACT_NO
    /// </summary>
    public string CONTRACT_NO { get; set; }

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
