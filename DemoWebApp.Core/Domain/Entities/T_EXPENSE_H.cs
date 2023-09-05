using System;
using System.Collections.Generic;

namespace DemoWebApp.Core.Domain.Entities;

public partial class T_EXPENSE_H
{
    /// <summary>
    /// รหัส Expense 
    /// </summary>
    public string EXPENSE_ID { get; set; }

    /// <summary>
    /// วันที่จ่ายเงิน
    /// </summary>
    public DateTime? EXPENSE_DATE { get; set; }

    public string EXPENSE_INVOICE_NO { get; set; }

    /// <summary>
    /// หมายเหตุ
    /// </summary>
    public string EXPENSE_REMARK { get; set; }

    /// <summary>
    /// ประเภทผู้รับเงิน
    /// </summary>
    public string EXPENSE_BENEFICIARY_TYPE { get; set; }

    /// <summary>
    /// ผู้รับเงิน
    /// </summary>
    public string EXPENSE_BENEFICIARY { get; set; }

    /// <summary>
    /// สถานะการอนุมัติ
    /// </summary>
    public string EXPENSE_APPROVE_FLAG { get; set; }

    /// <summary>
    /// ผู้อนุมัติ
    /// </summary>
    public string EXPENSE_APPROVE_BY { get; set; }

    /// <summary>
    /// วันที่อนุมัติ
    /// </summary>
    public DateTime? EXPENSE_APPROVE_DATE { get; set; }

    /// <summary>
    /// ผู้สร้าง
    /// </summary>
    public string EXPENSE_CREATE_BY { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? EXPENSE_CREATE_DATE { get; set; }

    /// <summary>
    /// ผู้แก้ไข
    /// </summary>
    public string EXPENSE_UPDATE_BY { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? EXPENSE_UPDATE_DATE { get; set; }

    /// <summary>
    /// สถานะการใช้งาน A= Active,I=Inactive
    /// </summary>
    public string EXPENSE_STATUS { get; set; }

    /// <summary>
    /// ประเภทค่าใช้จ่าย C=Court Fee,O=Other Expense
    /// </summary>
    public string EXPENSE_TYPE { get; set; }
}
