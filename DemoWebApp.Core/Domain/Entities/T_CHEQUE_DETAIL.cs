using System;
using System.Collections.Generic;

namespace DemoWebApp.Core.Domain.Entities;

public partial class T_CHEQUE_DETAIL
{
    /// <summary>
    /// [T_JOB_LEGAL.JOB_ID]
    /// </summary>
    public string CHQ_JOB_ID { get; set; }

    /// <summary>
    /// หมายเลขเช็ค
    /// </summary>
    public string CHQ_CHEQUE_NO { get; set; }

    public string CHQ_CONTRACT_NO { get; set; }

    /// <summary>
    /// ลำดับ
    /// </summary>
    public int? CHQ_SR_NO { get; set; }

    /// <summary>
    /// เลขที่บัญชี
    /// </summary>
    public string CHQ_ACCOUNT_NO { get; set; }

    /// <summary>
    /// รหัสธนาคาร
    /// </summary>
    public string CHQ_BANK_ID { get; set; }

    public string CHQ_BANK_NAME { get; set; }

    /// <summary>
    /// รหัสสาขา
    /// </summary>
    public string CHQ_BRANCH_NAME { get; set; }

    public string CHQ_BORROWER_NAME { get; set; }

    public string CHQ_CHEQUE_CLEARING_CODE { get; set; }

    public DateTime? CHQ_DEPOSIT_DATE { get; set; }

    /// <summary>
    /// วันที่อัพโหลด
    /// </summary>
    public DateTime? CHQ_UPLOAD_DATE { get; set; }

    /// <summary>
    /// วันที่กำหนดจ่ายเงิน
    /// </summary>
    public DateTime? CHQ_DUE_DATE { get; set; }

    public decimal? CHQ_EMI_AMOUNT { get; set; }

    public string CHQ_COMP_CODE { get; set; }

    public string CHQ_BRANCH_CODE { get; set; }
}
