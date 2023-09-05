using System;
using System.Collections.Generic;

namespace DemoWebApp.Core.Domain.Entities;

public partial class T_JOB_REPO
{
    /// <summary>
    /// รหัส Job
    /// </summary>
    public string JOB_ID { get; set; }

    /// <summary>
    /// เลขที่สัญญา
    /// </summary>
    public string JOB_CONTRACT_NO { get; set; }

    /// <summary>
    /// M_LEGAL_CASE.CASE_CODE
    /// </summary>
    public string JOB_CASE { get; set; }

    /// <summary>
    /// สถานะทางกฎหมาย
    /// </summary>
    public string JOB_LEGAL_STATUS { get; set; }

    /// <summary>
    /// สถานะการติดตามรถ
    /// </summary>
    public string JOB_REPO_STATUS { get; set; }

    /// <summary>
    /// ฐาน
    /// </summary>
    public int? JOB_BASE_COUNT { get; set; }

    /// <summary>
    /// สถานะตกชั้น
    /// </summary>
    public string JOB_REALLOCATE_FLAG { get; set; }

    /// <summary>
    /// รหัสผู้เช่าซื้อ
    /// </summary>
    public string JOB_CUST_CODE { get; set; }

    /// <summary>
    /// ชื่อ-นามสกุลผู้เช่าซื้อ
    /// </summary>
    public string JOB_CUST_NAME { get; set; }

    /// <summary>
    /// ประเภทผู้เช่าซื้อ
    /// </summary>
    public string JOB_CUST_TYPE { get; set; }

    /// <summary>
    /// เลขบัตรประชน
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
    /// กำหนดชำระ
    /// </summary>
    public DateTime? JOB_DUE_DATE { get; set; }

    /// <summary>
    /// ชำระทุกวันที่
    /// </summary>
    public int? JOB_DUE_DAY { get; set; }

    /// <summary>
    /// ค่างวดต่องวด
    /// </summary>
    public decimal? JOB_INST_AMT { get; set; }

    /// <summary>
    /// ระดับการติดตามหนี้ 
    /// </summary>
    public string JOB_BUCKET { get; set; }

    /// <summary>
    /// ค่างวดที่จ่ายไปแล้ว
    /// </summary>
    public decimal? JOB_INST_PAID { get; set; }

    /// <summary>
    /// จำนวนงวดที่จ่ายไปแล้ว
    /// </summary>
    public decimal? JOB_PAID_TERM { get; set; }

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
    /// สถานะเอกสาร
    /// </summary>
    public string JOB_DOC_FLAG { get; set; }

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
    /// วันที่ส่งจดหมาย R3
    /// </summary>
    public DateTime? JOB_R3_SEND_DATE { get; set; }

    /// <summary>
    /// วันที่ตอบรับจดหมาย R3
    /// </summary>
    public DateTime? JOB_R3_RECEVIE_DATE { get; set; }

    /// <summary>
    /// รหัส OA ที่ยึดรถสำเร็จ
    /// </summary>
    public string JOB_OA_SUCCESS { get; set; }

    /// <summary>
    /// สถานที่จอดรถ
    /// </summary>
    public string JOB_CAR_PARK { get; set; }

    /// <summary>
    /// วันที่ยึดรถ
    /// </summary>
    public DateTime? JOB_REPO_DATE { get; set; }

    /// <summary>
    /// วันที่ทำรายการ
    /// </summary>
    public DateTime? JOB_TRANS_DATE { get; set; }

    /// <summary>
    /// เลขไมล์
    /// </summary>
    public decimal? JOB_MILEAGE { get; set; }

    /// <summary>
    /// ประเภท การติดตามและยึดรถ
    /// </summary>
    public string JOB_REPO_TYPE { get; set; }

    /// <summary>
    /// วันที่เริ่มคำนวณค่าขาดประโยชน์
    /// </summary>
    public DateTime? JOB_CHARGE_DATE { get; set; }

    /// <summary>
    /// ค่าธรรมเนียม
    /// </summary>
    public decimal? JOB_FEE_EXPENSE { get; set; }

    /// <summary>
    /// ค่าใช้จ่ายในการติดตามรถ
    /// </summary>
    public decimal? JOB_REPO_EXPENSE { get; set; }

    /// <summary>
    /// ค่าใช้จ่ายอื่นๆ
    /// </summary>
    public decimal? JOB_OTHER_EXPENSE { get; set; }

    /// <summary>
    /// หมายเหตุการรับรถ
    /// </summary>
    public string JOB_RECEIVE_REMARK { get; set; }

    /// <summary>
    /// สถานะการแจ้งเตือน
    /// </summary>
    public string JOB_NOTI_FLAG { get; set; }

    public DateTime? JOB_RPS_DATE { get; set; }

    public string JOB_PROVINCE_CODE { get; set; }

    public string JOB_PROVINCE_REPO { get; set; }

    public string JOB_GEN_FLAG { get; set; }

    public string JOB_R3_ID { get; set; }

    /// <summary>
    /// วันที่เปลี่ยนสถานะ
    /// </summary>
    public DateTime? JOB_STEP_DATE { get; set; }

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
    /// สถานะการติดตามและยึดรถ
    /// </summary>
    public string JOB_STATUS { get; set; }
}
