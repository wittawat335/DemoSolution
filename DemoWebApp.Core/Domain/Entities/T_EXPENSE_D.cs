using System;
using System.Collections.Generic;

namespace DemoWebApp.Core.Domain.Entities;

public partial class T_EXPENSE_D
{
    /// <summary>
    /// running number
    /// </summary>
    public int EXPENSED_ID { get; set; }

    /// <summary>
    /// EXPENSE_H.EXPENSE_ID
    /// </summary>
    public string EXPENSED_HID { get; set; }

    /// <summary>
    /// รหัส Job ID
    /// </summary>
    public string EXPENSED_JOB_ID { get; set; }

    /// <summary>
    /// เลขที่สัญญา
    /// </summary>
    public string EXPENSED_CONTRACT_NO { get; set; }

    /// <summary>
    /// M_COURT.COURT_CODE รหัสศาล
    /// </summary>
    public string EXPENSED_COURT_CODE { get; set; }

    /// <summary>
    /// รหัส Expense [M_TRANSACTION.TRANS_CODE]
    /// </summary>
    public string EXPENSED_TRANS_CODE { get; set; }

    /// <summary>
    /// หมายเหตุ
    /// </summary>
    public string EXPENSED_REMARK { get; set; }

    public decimal? EXPENSED_AMOUNT_CLAIMED { get; set; }

    /// <summary>
    /// จำนวนเงินค่าใช้จ่าย
    /// </summary>
    public decimal? EXPENSED_AMT { get; set; }

    /// <summary>
    /// จำนวน VAT
    /// </summary>
    public decimal? EXPENSED_VAT { get; set; }

    public decimal? EXPENSED_TAX { get; set; }

    /// <summary>
    /// จำนวนเงินรวม
    /// </summary>
    public decimal? EXPENSED_TOTAL { get; set; }

    /// <summary>
    /// วันที่ยื่นฟ้อง
    /// </summary>
    public DateTime? EXPENSED_FILING_DATE { get; set; }

    /// <summary>
    /// ผู้สร้าง
    /// </summary>
    public string EXPENSED_CREATE_BY { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? EXPENSED_CREATE_DATE { get; set; }

    /// <summary>
    /// ผู้แก้ไข
    /// </summary>
    public string EXPENSED_UPDATE_BY { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? EXPENSED_UPDATE_DATE { get; set; }

    /// <summary>
    /// สถานะการใช้งาน A= Active,I=Inactive
    /// </summary>
    public string EXPENSED_STATUS { get; set; }

    /// <summary>
    /// อ้างอิง Payment No. เมื่อรับค่าธรรมเนียมศาลคืน
    /// </summary>
    public string EXPENSED_PAYMENT_REF { get; set; }

    public int? EXPENSED_ID_REF { get; set; }

    /// <summary>
    /// ประเภทการรับคืน [C=Cheque, T=Transfer]
    /// </summary>
    public string EXPENSED_RECEIVE_TYPE { get; set; }

    /// <summary>
    /// รหัสธนาคาร [M_MASTER.MASTER_CODE  MASTER_TYPE=&apos;BANK&apos;]
    /// </summary>
    public string EXPENSED_RECEIVE_BANK_CODE { get; set; }

    /// <summary>
    /// หมายเลขเช็คที่รับเงินคืน
    /// </summary>
    public string EXPENSED_RECEIVE_CHEQUE_NO { get; set; }

    public DateTime? EXPENSED_RECEIVE_CHEQUE_DATE { get; set; }

    /// <summary>
    /// สถานะรับเงินคืน [0=จ่ายเงิน,1=รับเงินคืน]
    /// </summary>
    public string EXPENSED_RECVIVE_FLAG { get; set; }
}
