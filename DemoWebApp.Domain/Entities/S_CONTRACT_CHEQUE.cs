using System;
using System.Collections.Generic;

namespace DemoWebApp.Domain.Entities;

public partial class S_CONTRACT_CHEQUE
{
    /// <summary>
    /// เลขที่สัญญา
    /// </summary>
    public string CONTRACT_NO { get; set; }

    /// <summary>
    /// serial number
    /// </summary>
    public int SR_NO { get; set; }

    /// <summary>
    /// ลำดับเช็ค
    /// </summary>
    public int? CHEQUE_SEQUENCE { get; set; }

    /// <summary>
    /// เลขบัญชี
    /// </summary>
    public string ACCOUNT_NO { get; set; }

    /// <summary>
    /// รหัสธนาคาร
    /// </summary>
    public string BANK_ID { get; set; }

    /// <summary>
    /// รหัสสาขาธนาคาร
    /// </summary>
    public string BRANCH_ID { get; set; }

    /// <summary>
    /// การเรียกเก็บเงินตามเช็ค 
    /// </summary>
    public string CHEQUE_CLEARING_CD { get; set; }

    /// <summary>
    /// วันที่ฝากเช็ค
    /// </summary>
    public DateTime? CHEQUE_DEPOSIT_DATE { get; set; }

    /// <summary>
    /// หมายเลขเช็ค
    /// </summary>
    public string CHEQUE_NO { get; set; }

    public DateTime? CHEQUE_UPLOAD_DATE { get; set; }

    /// <summary>
    /// วันที่กำหนดชำระ
    /// </summary>
    public DateTime? DUE_DATE { get; set; }

    public decimal? EMI_AMNT { get; set; }

    /// <summary>
    /// สถานะบันทึก
    /// </summary>
    public string RECORD_STATUS { get; set; }

    /// <summary>
    /// สถานะยกเลิก
    /// </summary>
    public string REJECTION_STATUS { get; set; }

    /// <summary>
    /// วันที่เปลี่ยนสถานะ
    /// </summary>
    public DateTime? STATUS_DATE { get; set; }

    public bool? PDC_LETTER_GENERATED_FLG { get; set; }

    /// <summary>
    /// วันที่นำข้อมูลเข้า
    /// </summary>
    public DateTime? DATA_IMPORT_DATE { get; set; }

    public string COMP_CODE { get; set; }

    public string COMP_BRANCH_CODE { get; set; }
}
