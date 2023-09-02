using System;
using System.Collections.Generic;

namespace DemoWebApp.Domain.Entities;

public partial class T_JUDGMENTDEBTOR_D
{
    /// <summary>
    /// รหัส T_JUDGMENTDEBTOR_D
    /// </summary>
    public int JDD_ID { get; set; }

    /// <summary>
    /// [T_JUDGMENTDEBTOR_H.JD_ID]
    /// </summary>
    public string JDD_HID { get; set; }

    public int JDD_SEQ { get; set; }

    /// <summary>
    /// M_TRANSACTION.TRANS_CODE
    /// </summary>
    public string JDD_TRANS_CODE { get; set; }

    /// <summary>
    /// จำนวนเงินที่ตั้งไว้ 
    /// </summary>
    public decimal? JDD_AMOUNT { get; set; }

    /// <summary>
    /// เงินที่เรียกเก็บได้จริง
    /// </summary>
    public decimal? JDD_PAYMENT_AMOUNT { get; set; }

    /// <summary>
    /// สถานะการส่งให้เครดิตรบูโร
    /// </summary>
    public string JDD_CREDITBUREAU_FLAG { get; set; }

    /// <summary>
    /// สถานะการคำนวณหนี้ตามคำพิพากษา
    /// </summary>
    public string JDD_SUM_FLAG { get; set; }

    /// <summary>
    /// สถานะการคำนวณตารางการชำระแบบแบ่งจ่าย
    /// </summary>
    public string JDD_GENERATE_FLAG { get; set; }

    /// <summary>
    /// สถานะการคิดดอกเบี้ย
    /// </summary>
    public string JDD_INTEREST_FLAG { get; set; }

    /// <summary>
    /// ประเภทการคำนวณดอกเบื้ย
    /// </summary>
    public string JDD_INTEREST_TYPE { get; set; }

    /// <summary>
    /// วันที่เริ่มต้นคำนวณดอกเบี้ย
    /// </summary>
    public DateTime? JDD_INTEREST_START_DATE { get; set; }

    /// <summary>
    /// วันที่สิ้นสุดคำนวณดอกเบี้ย
    /// </summary>
    public DateTime? JDD_INTEREST_END_DATE { get; set; }

    /// <summary>
    /// สถานะวันสิ้นสุดการคิดดอกเบี้ย
    /// </summary>
    public string JDD_INTEREST_END_DATE_FLAG { get; set; }

    /// <summary>
    /// จำนวนเดือนที่คิดดอกเบื้ย
    /// </summary>
    public int? JDD_INTEREST_MONTHS { get; set; }

    /// <summary>
    /// จำนวนวันที่คิดดอกเบื้ย
    /// </summary>
    public int? JDD_INTEREST_DAYS { get; set; }

    /// <summary>
    /// อัตราดอกเบี้ย
    /// </summary>
    public decimal? JDD_INTEREST_RATE { get; set; }

    public string JDD_MONTHS_FLAG { get; set; }

    public int? JDD_MONTHS { get; set; }

    /// <summary>
    /// หมายเหตุ
    /// </summary>
    public string JDD_REMARK { get; set; }

    /// <summary>
    /// ผู้สร้าง
    /// </summary>
    public string JDD_CREATE_BY { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? JDD_CREATE_DATE { get; set; }

    /// <summary>
    /// ผู้แก้ไข
    /// </summary>
    public string JDD_UPDATE_BY { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? JDD_UPDATE_DATE { get; set; }

    /// <summary>
    /// สถานะการใช้งาน A= Active,I=Inactive
    /// </summary>
    public string JDD_STATUS { get; set; }
}
