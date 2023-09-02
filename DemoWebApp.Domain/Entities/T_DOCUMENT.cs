using System;
using System.Collections.Generic;

namespace DemoWebApp.Domain.Entities;

public partial class T_DOCUMENT
{
    /// <summary>
    /// รหัส Job
    /// </summary>
    public string TDOC_JOB_ID { get; set; }

    /// <summary>
    /// เลขที่สัญญา
    /// </summary>
    public string TDOC_CONTRACT_NO { get; set; }

    /// <summary>
    /// รหัสเอกสาร
    /// </summary>
    public string TDOC_DOC_CODE { get; set; }

    /// <summary>
    /// สถานะของเอกสารที่ Success
    /// </summary>
    public string TDOC_SUCC_FLAG { get; set; }

    /// <summary>
    /// สถานะของเอกสารที่ Fail
    /// </summary>
    public string TDOC_FAIL_FLAG { get; set; }

    /// <summary>
    /// รหัสเหตุผลเอกสาร
    /// </summary>
    public string TDOC_REASON_CODE { get; set; }

    /// <summary>
    /// หมายเหตุ
    /// </summary>
    public string TDOC_REMARK { get; set; }

    /// <summary>
    /// ผู้สร้าง
    /// </summary>
    public string TDOC_CREATE_BY { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? TDOC_CRREATE_DATE { get; set; }

    /// <summary>
    /// ผู้แก้ไข
    /// </summary>
    public string TDOC_UPDATE_BY { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? TDOC_UPDATE_DATE { get; set; }

    /// <summary>
    /// สถานะการใช้งาน A= Active,I=Inactive
    /// </summary>
    public string TDOC_STATUS { get; set; }
}
