using System;
using System.Collections.Generic;

namespace DemoWebApp.Domain.Entities;

public partial class T_JOB_R3
{
    /// <summary>
    /// รหัส job
    /// </summary>
    public string JOB_ID { get; set; }

    /// <summary>
    /// เลขที่สัญญา
    /// </summary>
    public string JOB_CONTRACT_NO { get; set; }

    /// <summary>
    /// สถานะของจดหมาย 10 = กำลังรอส่ง 20 = รอการบันทึกการส่งจดหมาย  30 ดำเนินการสำเร็จ
    /// </summary>
    public string JOB_R3_STATUS { get; set; }

    /// <summary>
    /// ฐาน
    /// </summary>
    public int? JOB_BASE_COUNT { get; set; }

    /// <summary>
    /// รหัสลูกค้า
    /// </summary>
    public string JOB_CUST_CODE { get; set; }

    /// <summary>
    /// ชื่อ-นามสกุลลูกค้า
    /// </summary>
    public string JOB_CUST_NAME { get; set; }

    /// <summary>
    /// ประเภทลูกค้าใน Contract (Borrower, Guarantor)
    /// </summary>
    public string JOB_CUST_BR_TYPE { get; set; }

    /// <summary>
    /// ประเภทของลูกค้า (Person, Corporate)
    /// </summary>
    public string JOB_CUST_CR_TYPE { get; set; }

    /// <summary>
    /// เลขที่บัตรแสดงตน (บัตรประชาชน หรือ เลขที่นิติบุคคล)
    /// </summary>
    public string JOB_CARD_NO { get; set; }

    /// <summary>
    /// รหัส Admin
    /// </summary>
    public string JOB_ADMIN_CODE { get; set; }

    /// <summary>
    /// รหัส OA
    /// </summary>
    public string JOB_OA_CODE { get; set; }

    /// <summary>
    /// ระดับการติดตามหนี้ 
    /// </summary>
    public string JOB_BUCKET { get; set; }

    /// <summary>
    /// จำนวนเงินคงเหลือ
    /// </summary>
    public decimal? JOB_OS_AMT { get; set; }

    /// <summary>
    /// จำนวนเงินค้างชำระ
    /// </summary>
    public decimal? JOB_OVD_AMT { get; set; }

    /// <summary>
    /// จำนวนวันที่ค้างชำระ
    /// </summary>
    public int? JOB_OVD_DAY { get; set; }

    /// <summary>
    /// จำนวนงวดค้างชำระ
    /// </summary>
    public decimal? JOB_OVD_TERM { get; set; }

    /// <summary>
    /// ยี่ห้อรถ
    /// </summary>
    public string JOB_BRAND { get; set; }

    /// <summary>
    /// รุ่นรถ
    /// </summary>
    public string JOB_MODEL { get; set; }

    /// <summary>
    /// เลขทะเบียนรถ
    /// </summary>
    public string JOB_PLATE_NO { get; set; }

    /// <summary>
    /// รายละเอียดสินทรัพย์
    /// </summary>
    public string JOB_ASSET_DESC { get; set; }

    /// <summary>
    /// วันหมดอายุ
    /// </summary>
    public DateTime? JOB_EXPIRE_DATE { get; set; }

    /// <summary>
    /// ผู้จ่ายงาน
    /// </summary>
    public string JOB_ASSIGN_BY { get; set; }

    /// <summary>
    /// วันที่จ่ายงานให้ Admin
    /// </summary>
    public DateTime? JOB_ASSIGN_ADMIN_DATE { get; set; }

    /// <summary>
    /// วันที่จ่ายงานให้ OA
    /// </summary>
    public DateTime? JOB_ASSIGN_OA_DATE { get; set; }

    /// <summary>
    /// หมายเหตุการจ่ายงาน
    /// </summary>
    public string JOB_ASSIGN_REMARK { get; set; }

    /// <summary>
    /// วันที่เปลี่ยนสถานะ
    /// </summary>
    public DateTime? JOB_STEP_DATE { get; set; }

    /// <summary>
    /// วันที่ส่งจดหมาย R3
    /// </summary>
    public DateTime? JOB_R3_SEND_DATE { get; set; }

    /// <summary>
    /// วันที่ลูกค้าตอบรับจดหมาย R3 ล่าสุด
    /// </summary>
    public DateTime? JOB_R3_RECEVIE_DATE { get; set; }

    public string JOB_GEN_FLAG { get; set; }

    /// <summary>
    /// ผู้สร้าง
    /// </summary>
    public string JOB_CREATE_BY { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? JOB_CREATE_DATE { get; set; }

    /// <summary>
    /// ผู้แก้ไข
    /// </summary>
    public string JOB_UPDATE_BY { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? JOB_UPDATE_DATE { get; set; }

    /// <summary>
    /// สถานะการใช้งาน A= Active,I=Inactive
    /// </summary>
    public string JOB_STATUS { get; set; }

    public string JOB_COMP_CODE { get; set; }

    public string JOB_BRACH_CODE { get; set; }
}
