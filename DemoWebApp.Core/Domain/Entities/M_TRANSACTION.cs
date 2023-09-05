using System;
using System.Collections.Generic;

namespace DemoWebApp.Core.Domain.Entities;

public partial class M_TRANSACTION
{
    /// <summary>
    /// รหัสรายการ รายการชำระ 
    /// </summary>
    public string TRANS_CODE { get; set; }

    /// <summary>
    /// ชื่อไทย
    /// </summary>
    public string TRANS_NAME_TH { get; set; }

    /// <summary>
    /// ชื่ออังกฤษ
    /// </summary>
    public string TRANS_NAME_EN { get; set; }

    /// <summary>
    /// M_Master.Master_Code [MasterInfoType=GTTP]
    /// </summary>
    public string TRANS_GROUP_CODE { get; set; }

    /// <summary>
    /// จำนวนเงินค่าใช้จ่าย
    /// </summary>
    public decimal? TRANS_AMT { get; set; }

    /// <summary>
    /// สถานะคิด Vat
    /// </summary>
    public string TRANS_VAT_FLAG { get; set; }

    /// <summary>
    /// สถานะ TAX
    /// </summary>
    public string TRANS_TAX_FLAG { get; set; }

    public string TRANS_DUP_FLAG { get; set; }

    public string TRANS_EST_FLAG { get; set; }

    /// <summary>
    /// ผู้สร้าง
    /// </summary>
    public string TRANS_CREATE_BY { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? TRANS_CREATE_DATE { get; set; }

    /// <summary>
    /// ผู้แก้ไข
    /// </summary>
    public string TRANS_UPDATE_BY { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? TRANS_UPDATE_DATE { get; set; }

    /// <summary>
    /// สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน
    /// </summary>
    public string TRANS_STATUS { get; set; }
}
