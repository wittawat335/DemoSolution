using System;
using System.Collections.Generic;

namespace DemoWebApp.Core.Domain.Entities;

public partial class T_JUDGMENTDEBTOR_H
{
    /// <summary>
    /// รหัส JUDGMENTDEBTOR_H
    /// </summary>
    public string JD_ID { get; set; }

    /// <summary>
    /// ประเภทการฟ้อง [Contract, Cheque]
    /// </summary>
    public string JD_TYPE { get; set; }

    /// <summary>
    /// [T_JOB_LEGAL.JOB_ID]
    /// </summary>
    public string JD_JOB_ID { get; set; }

    public string JD_CONTRACT_LIST { get; set; }

    public string JD_CHEQUE_LIST { get; set; }

    /// <summary>
    /// สถานะลูกหนี้
    /// </summary>
    public string JD_DEBTOR_STATUS { get; set; }

    /// <summary>
    /// วันที่ประนีประนอม
    /// </summary>
    public DateTime? JD_JUDGMENT_DATE { get; set; }

    /// <summary>
    /// วันที่ประนีประนอม
    /// </summary>
    public DateTime? JD_COMPROMISE_DATE { get; set; }

    /// <summary>
    /// รายละเอียด
    /// </summary>
    public string JD_FURTHER_COMMENT { get; set; }

    /// <summary>
    /// จำนวนงวดที่แบ่งจ่าย
    /// </summary>
    public int? JD_TERM { get; set; }

    public decimal? JD_TOTAL { get; set; }

    /// <summary>
    /// วันแรกที่ต้องจ่าย
    /// </summary>
    public DateTime? JD_FIRST_DUE_DATE { get; set; }

    /// <summary>
    /// จ่ายทุกวันที่
    /// </summary>
    public int? JD_PAY_DAY { get; set; }

    /// <summary>
    /// สถานะการอนุมัติ
    /// </summary>
    public string JD_APPROVE_FLAG { get; set; }

    /// <summary>
    /// ผู้อนุมัติ
    /// </summary>
    public string JD_APPROVE_BY { get; set; }

    /// <summary>
    /// วันที่อนุมัติ
    /// </summary>
    public DateTime? JD_APPROVE_DATE { get; set; }

    public string JD_APPROVE_REMARK { get; set; }

    /// <summary>
    /// หมายเหตุ
    /// </summary>
    public string JD_REMARK { get; set; }

    /// <summary>
    /// สถานะใช้งาน A=Active,I=Inactive
    /// </summary>
    public string JD_STATUS { get; set; }

    /// <summary>
    /// ผู้สร้าง
    /// </summary>
    public string JD_CREATE_BY { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? JD_CREATE_DATE { get; set; }

    /// <summary>
    /// ผู้แก้ไข
    /// </summary>
    public string JD_UPDATE_BY { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? JD_UPDATE_DATE { get; set; }
}
