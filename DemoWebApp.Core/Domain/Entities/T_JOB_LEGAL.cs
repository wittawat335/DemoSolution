using System;
using System.Collections.Generic;

namespace DemoWebApp.Core.Domain.Entities;

public partial class T_JOB_LEGAL
{
    /// <summary>
    /// รหัส JOB
    /// </summary>
    public string JOB_ID { get; set; }

    /// <summary>
    /// S_CONTRACT_DETAIL.CONTRACT_NO
    /// </summary>
    public string JOB_CONTRACT_NO { get; set; }

    /// <summary>
    /// M_LEGAL_CASE.CASE_CODE
    /// </summary>
    public string JOB_CASE { get; set; }

    public string JOB_CASE_OTHER { get; set; }

    public string JOB_CASE_TYPE { get; set; }

    /// <summary>
    /// สถานะ Legal
    /// </summary>
    public string JOB_LEGAL_STATUS { get; set; }

    /// <summary>
    /// สถานะการยึดรถ
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
    /// รหัสลูกค้า
    /// </summary>
    public string JOB_CUST_CODE { get; set; }

    /// <summary>
    /// ชื่อ-นามสกุลลูกค้า
    /// </summary>
    public string JOB_CUST_NAME { get; set; }

    /// <summary>
    /// ประเภทลูกค้า
    /// </summary>
    public string JOB_CUST_TYPE { get; set; }

    public string JOB_CUST_ADDRESS { get; set; }

    /// <summary>
    /// เลขบัตรประชาชน
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
    /// วันที่แจกงานให้ Admin
    /// </summary>
    public DateTime? JOB_ASSIGN_ADMIN_DATE { get; set; }

    /// <summary>
    /// วันที่แจกงานให้ OA
    /// </summary>
    public DateTime? JOB_ASSIGN_OA_DATE { get; set; }

    /// <summary>
    /// หมายเหตุแจกงาน
    /// </summary>
    public string JOB_ASSIGN_REMARK { get; set; }

    /// <summary>
    /// วันที่ยื่นเรื่องฟ้องศาล
    /// </summary>
    public DateTime? JOB_FILING_DATE { get; set; }

    public string JOB_AML_ORDER_NO { get; set; }

    public DateTime? JOB_AML_ORDER_DATE { get; set; }

    public DateTime? JOB_ANNOUNCE_DATE { get; set; }

    /// <summary>
    /// วันนัดหมาย
    /// </summary>
    public DateTime? JOB_APPOINT_DATE { get; set; }

    /// <summary>
    /// วันสุดท้ายที่จ่ายเงิน
    /// </summary>
    public DateTime? JOB_LAST_DUE_DATE { get; set; }

    public DateTime? JOB_RECEIVE_ORDER_DATE { get; set; }

    public DateTime? JOB_REQUEST_DATE { get; set; }

    /// <summary>
    /// สถานที่รับรถ
    /// </summary>
    public string JOB_CAR_RECEIVE_PLACE { get; set; }

    public DateTime? JOB_CAR_RECEIVE_DATE { get; set; }

    public string JOB_INSURER_NAME { get; set; }

    public string JOB_ORDERED_REH { get; set; }

    /// <summary>
    /// ชื่อโจทย์
    /// </summary>
    public string JOB_PLAINTIFF_NAME { get; set; }

    /// <summary>
    /// หมายเหตุ
    /// </summary>
    public string JOB_REMARK { get; set; }

    public string JOB_REQUESTOR { get; set; }

    public string JOB_COMPANY_PLAN { get; set; }

    /// <summary>
    /// จำนวนเงินประกัน
    /// </summary>
    public decimal? JOB_ASSURED_AMOUNT { get; set; }

    /// <summary>
    /// จำนวนเงินที่เรียกร้อง
    /// </summary>
    public decimal? JOB_AMOUNT_CLAIMED { get; set; }

    /// <summary>
    /// ส่วนขาดทุน
    /// </summary>
    public decimal? JOB_SHORT_FALL { get; set; }

    /// <summary>
    /// ค่าเสียหายโดนสิ้นเชิง
    /// </summary>
    public decimal? JOB_TOTAL_LOSS_AMOUNT { get; set; }

    public string JOB_CONTRACT_LIST { get; set; }

    public string JOB_CHEQUE_LIST { get; set; }

    /// <summary>
    /// วันที่ส่งจดหมาย R3
    /// </summary>
    public DateTime? JOB_MAILING_DATE { get; set; }

    /// <summary>
    /// Debtor Status
    /// </summary>
    public string JOB_DEBTOR_STATUS { get; set; }

    /// <summary>
    /// เลขคดีดำ
    /// </summary>
    public string JOB_BLACK_CODE { get; set; }

    /// <summary>
    /// เลขคดีแดง
    /// </summary>
    public string JOB_RED_CODE { get; set; }

    /// <summary>
    /// Attorney Status
    /// </summary>
    public string JOB_ATTORNEY_STATUS { get; set; }

    /// <summary>
    /// ศาล
    /// </summary>
    public string JOB_COURT_CODE { get; set; }

    /// <summary>
    /// ค่าธรรมเนียมศาล
    /// </summary>
    public decimal? JOB_COURT_FEE { get; set; }

    /// <summary>
    /// Police Station
    /// </summary>
    public string JOB_POLICE_STATION { get; set; }

    /// <summary>
    /// Submission Date
    /// </summary>
    public DateTime? JOB_SUBMISSION_DATE { get; set; }

    /// <summary>
    /// Payment Submission Amount
    /// </summary>
    public decimal? JOB_SUBMISSION_AMOUNT { get; set; }

    /// <summary>
    /// Contract Terminated Date
    /// </summary>
    public DateTime? JOB_CONTRACT_TERMINATED_DATE { get; set; }

    /// <summary>
    /// Opportunity Cost
    /// </summary>
    public decimal? JOB_LACK_OF_BENEFIT { get; set; }

    /// <summary>
    /// Cheque No.
    /// </summary>
    public string JOB_CHEQUE_NO { get; set; }

    /// <summary>
    /// Notify Cheque Date
    /// </summary>
    public DateTime? JOB_NOTIFY_CHEQUE_DATE { get; set; }

    public string JOB_PARTY_IN_LAW_SUIT { get; set; }

    public DateTime? JOB_APPOINTED_DATE { get; set; }

    /// <summary>
    /// Assigned Date
    /// </summary>
    public DateTime? JOB_ASSIGNED_DATE { get; set; }

    /// <summary>
    /// Attorney Date
    /// </summary>
    public DateTime? JOB_ATTORNEY_DATE { get; set; }

    /// <summary>
    /// วันทีนำส่งหมายศาล
    /// </summary>
    public DateTime? JOB_NOTICE_DATE { get; set; }

    /// <summary>
    /// Witness Date
    /// </summary>
    public DateTime? JOB_WITNESS_DATE { get; set; }

    /// <summary>
    /// Witness Time
    /// </summary>
    public string JOB_WITNESS_TIME { get; set; }

    /// <summary>
    /// Lawyer Fee
    /// </summary>
    public decimal? JOB_LAWYER_FEE { get; set; }

    /// <summary>
    /// Second Lawyer Fee
    /// </summary>
    public decimal? JOB_SECOND_LAWYER_FEE { get; set; }

    /// <summary>
    /// วันที่บังคับฟ้อง
    /// </summary>
    public DateTime? JOB_ENFORCEMENT_DATE { get; set; }

    /// <summary>
    /// Bankruptcy Date
    /// </summary>
    public DateTime? JOB_BANKRUPTCY_DATE { get; set; }

    /// <summary>
    /// Discharged from Bankruptcy Date
    /// </summary>
    public DateTime? JOB_BANKRUPTCY_DISCHARGED_DATE { get; set; }

    /// <summary>
    /// POL No
    /// </summary>
    public string JOB_POL_NO { get; set; }

    /// <summary>
    /// หมายเลขตั้งบังคับคดี
    /// </summary>
    public string JOB_STOLEN_NO { get; set; }

    /// <summary>
    /// วันนัดตรวจคำขอรับชำระหนี้
    /// </summary>
    public DateTime? JOB_APPOINTMENT_CHECK_DATE { get; set; }

    /// <summary>
    /// OA บังคับคดี
    /// </summary>
    public string JOB_OA_ENFORCEMENT { get; set; }

    /// <summary>
    /// วันทีส่งไปบังคับคดี
    /// </summary>
    public DateTime? JOB_SUBMIT_ENFORCEMENT_DATE { get; set; }

    /// <summary>
    /// OA สืบทรัพย์
    /// </summary>
    public string JOB_OA_ASSET_SEARCH { get; set; }

    /// <summary>
    /// วันที่ส่งไปสืบทรัพย์
    /// </summary>
    public DateTime? JOB_SUBMIT_INVEST_DATE { get; set; }

    /// <summary>
    /// วันที่ตั้งเรื่องบังคับคดี
    /// </summary>
    public DateTime? JOB_ENFORCEMENT_EFF_DATE { get; set; }

    /// <summary>
    /// วันที่รับเงิน
    /// </summary>
    public DateTime? JOB_CASH_RECEIVE_DATE { get; set; }

    /// <summary>
    /// วันที่นำยึด
    /// </summary>
    public DateTime? JOB_SEIZE_DATE { get; set; }

    /// <summary>
    /// วันที่ส่งรายงานสืบทรัพย์
    /// </summary>
    public DateTime? JOB_REPORT_DATE { get; set; }

    /// <summary>
    /// วันที่ศาลพิพากษา
    /// </summary>
    public DateTime? JOB_JUDGMENT_DATE { get; set; }

    /// <summary>
    /// วันที่ถอนฟ้อง
    /// </summary>
    public DateTime? JOB_WITHDRAW_DATE { get; set; }

    /// <summary>
    /// วันที่บังคับคดี
    /// </summary>
    public DateTime? JOB_EXECUTION_DATE { get; set; }

    /// <summary>
    /// วันสิ้นสุดบังคับคดี
    /// </summary>
    public DateTime? JOB_EXECUTION_END_DATE { get; set; }

    /// <summary>
    /// รายละเอียด
    /// </summary>
    public string JOB_DETAILS { get; set; }

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
    /// สถานะการใช้งาน A= Active,I=Inactive
    /// </summary>
    public string JOB_STATUS { get; set; }
}
