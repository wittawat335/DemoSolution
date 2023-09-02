using System;
using System.Collections.Generic;

namespace DemoWebApp.Domain.Entities;

public partial class T_R3_DETAIL
{
    /// <summary>
    /// เลขที่งานของจดหมาย Running By System
    /// </summary>
    public string R3_JOB_ID { get; set; }

    /// <summary>
    /// รหัสลูกค้า
    /// </summary>
    public string R3_CUST_CODE { get; set; }

    /// <summary>
    /// ประเภทที่อยู่ M= Mailing  , R= Registered
    /// </summary>
    public string R3_ADDR_ID { get; set; }

    /// <summary>
    /// เลขที่สัญญา
    /// </summary>
    public string R3_CONTRACT_NO { get; set; }

    /// <summary>
    /// ชื่อ-นามสกุลผู้เช่าซื้อ
    /// </summary>
    public string R3_CUST_NAME { get; set; }

    /// <summary>
    /// ประเภทผู้รับจดหมาย B= Borrower  , G= Guarantor
    /// </summary>
    public string R3_CUST_BR_TYPE { get; set; }

    /// <summary>
    /// เลขที่บัตรประชาชน
    /// </summary>
    public string R3_CARD_NO { get; set; }

    /// <summary>
    /// ที่อยู่ของผู้รับจดหมาย
    /// </summary>
    public string R3_ADDR_FULL { get; set; }

    /// <summary>
    /// วันที่ Printing Provider ส่งจดหมายให้กับผู้เช่าซื้อ
    /// </summary>
    public DateTime? R3_SEND_DATE { get; set; }

    /// <summary>
    /// วันที่ลูกค้าตอบรับใบเหลือง
    /// </summary>
    public DateTime? R3_RECEVIE_DATE { get; set; }

    public DateTime? R3_REJECTED_DATE { get; set; }

    /// <summary>
    /// วันที่ Generate ออกจากระบบ หรือวันที่ส่งให้ Printing Provider
    /// </summary>
    public DateTime? R3_ISSUE_DATE { get; set; }

    /// <summary>
    /// สถานะของจดหมาย 10 = กำลังรอส่ง 20 = รอการบันทึกการส่งจดหมาย  30=ดำเนินการสำเร็จ
    /// </summary>
    public string R3_CASE_STATUS { get; set; }

    /// <summary>
    /// เลขทะเบียนการส่งจดหมาย
    /// </summary>
    public string R3_EMS_TRACKING { get; set; }

    /// <summary>
    /// วันที่จดหมายหมดอายุ 30 วัน
    /// </summary>
    public DateTime? R3_EXPIRE_DATE { get; set; }

    /// <summary>
    /// วันที่ควรได้รับการตอบรับจากลูกค้า คำนวนจาก Send Date+Parameter
    /// </summary>
    public DateTime? R3_TARGET_DATE { get; set; }

    /// <summary>
    /// หมายเหตุ
    /// </summary>
    public string R3_REMARK { get; set; }

    /// <summary>
    /// หมายเลขบาร์โค้ด สำหรับสแกนเมื่อลูกค้าตอบจดหมาย R3
    /// </summary>
    public string R3_BARCODE { get; set; }

    public string R3_FLAG { get; set; }

    /// <summary>
    /// เพิ่มข้อมูลโดย
    /// </summary>
    public string R3_CREATE_BY { get; set; }

    /// <summary>
    /// วันที่เพิ่มข้อมูล
    /// </summary>
    public DateTime? R3_CREATE_DATE { get; set; }

    /// <summary>
    /// ปรับปรุงข้อมูลล่าสุดโดย
    /// </summary>
    public string R3_UPDATE_BY { get; set; }

    /// <summary>
    /// วันที่ปรับปรุงข้อมูลล่าสุด
    /// </summary>
    public DateTime? R3_UPDATE_DATE { get; set; }

    /// <summary>
    /// สถานะการใช้งาน A= Active  , I = Inactive
    /// </summary>
    public string R3_STATUS { get; set; }
}
