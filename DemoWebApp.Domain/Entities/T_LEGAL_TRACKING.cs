using System;
using System.Collections.Generic;

namespace DemoWebApp.Domain.Entities;

public partial class T_LEGAL_TRACKING
{
    /// <summary>
    /// รหัส job
    /// </summary>
    public string LEGAL_JOB_ID { get; set; }

    /// <summary>
    /// ลำดับ
    /// </summary>
    public int LEGAL_SEQ_NO { get; set; }

    /// <summary>
    /// กรณีคดีทางกฎหมาย M_LEGAL_CASE.CASE_CODE
    /// </summary>
    public string LEGAL_CASE { get; set; }

    /// <summary>
    /// เลขที่สัญญา
    /// </summary>
    public string LEGAL_CONTRACT_NO { get; set; }

    /// <summary>
    /// วันที่ติดตาม
    /// </summary>
    public DateTime? LEGAL_TRACKING_DATE { get; set; }

    /// <summary>
    /// ผู้ติดตาม
    /// </summary>
    public string LEGAL_TRACKING_BY { get; set; }

    /// <summary>
    /// วันที่ส่งจดหมาย
    /// </summary>
    public DateTime? LEGAL_MAILING_DATE { get; set; }

    /// <summary>
    /// วันที่ยื่นฟ้องร้อง
    /// </summary>
    public DateTime? LEGAL_FILING_DATE { get; set; }

    /// <summary>
    /// สถานะคดีทางกฎหมาย
    /// </summary>
    public string LEGAL_STATUS { get; set; }

    /// <summary>
    /// สถานะลูกหนี้
    /// </summary>
    public string LEGAL_DEBTOR_STATUS { get; set; }

    /// <summary>
    /// เลขคดีดำ
    /// </summary>
    public string LEGAL_BLACK_CODE { get; set; }

    /// <summary>
    /// เลขคดีแดง
    /// </summary>
    public string LEGAL_RED_CODE { get; set; }

    /// <summary>
    /// สถานะการไต่สวน
    /// </summary>
    public string LEGAL_ATTORNEY_STATUS { get; set; }

    /// <summary>
    /// M_COURT.COURT_CODE
    /// </summary>
    public string LEGAL_COURT_CODE { get; set; }

    /// <summary>
    /// ค่าธรรมเนียมศาล
    /// </summary>
    public decimal? LEGAL_COURT_FEE { get; set; }

    /// <summary>
    /// ทุนทรัพย์ฟ้อง
    /// </summary>
    public decimal? LEGAL_AMOUNT_CLAIMED { get; set; }

    /// <summary>
    /// สถานีตำรวจ
    /// </summary>
    public string LEGAL_POLICE_STATION { get; set; }

    /// <summary>
    /// สถานที่รับรถ
    /// </summary>
    public string LEGAL_CAR_RECEIVED_PLACE { get; set; }

    public DateTime? LEGAL_SUBMISSION_DATE { get; set; }

    public decimal? LEGAL_SUBMISSION_AMOUNT { get; set; }

    /// <summary>
    /// วันที่เลิกสัญญา
    /// </summary>
    public DateTime? LEGAL_CONTRACT_TERMINATED_DATE { get; set; }

    /// <summary>
    /// ค่าขาดประโยชน์
    /// </summary>
    public decimal? LEGAL_LACK_OF_BENEFIT { get; set; }

    /// <summary>
    /// หมายเลขเช็ค
    /// </summary>
    public string LEGAL_CHEQUE_NO { get; set; }

    /// <summary>
    /// วันที่ฟ้องคดีเช็ค
    /// </summary>
    public DateTime? LEGAL_NOTIFY_CHEQUE_DATE { get; set; }

    public string LEGAL_PARTY_IN_LAW_SUIT { get; set; }

    public DateTime? LEGAL_APPOINTED_DATE { get; set; }

    /// <summary>
    /// วันที่ฝ่ายกฎหมายได้รับสัญญา
    /// </summary>
    public DateTime? LEGAL_ASSIGNED_DATE { get; set; }

    /// <summary>
    /// วันที่นัดไต่สวน
    /// </summary>
    public DateTime? LEGAL_ATTORNEY_DATE { get; set; }

    /// <summary>
    /// วันที่ฟ้อง
    /// </summary>
    public DateTime? LEGAL_NOTICE_DATE { get; set; }

    /// <summary>
    /// วันที่นัดสืบพยาน
    /// </summary>
    public DateTime? LEGAL_WITNESS_DATE { get; set; }

    /// <summary>
    /// เวลานัดสืบพยาน
    /// </summary>
    public string LEGAL_WITNESS_TIME { get; set; }

    /// <summary>
    /// ค่าทนายความ
    /// </summary>
    public decimal? LEGAL_LAWYER_FEE { get; set; }

    public decimal? LEGAL_SECOND_LAWYER_FEE { get; set; }

    /// <summary>
    /// วันที่บังคับฟ้อง
    /// </summary>
    public DateTime? LEGAL_ENFORCEMENT_DATE { get; set; }

    /// <summary>
    /// วันที่ล้มละลาย
    /// </summary>
    public DateTime? LEGAL_BANKRUPTCY_DATE { get; set; }

    /// <summary>
    /// วันที่ปลดจากล้มละลาย
    /// </summary>
    public DateTime? LEGAL_BANKRUPTCY_DISCHARGED_DATE { get; set; }

    /// <summary>
    /// เลขอาญา
    /// </summary>
    public string LEGAL_POL_NO { get; set; }

    /// <summary>
    /// หมายเลขตั้งบังคับคดี
    /// </summary>
    public string LEGAL_STOLEN_NO { get; set; }

    public DateTime? LEGAL_APPOINTMENT_CHECK_DATE { get; set; }

    public string LEGAL_OA_ENFORCEMENT { get; set; }

    public DateTime? LEGAL_SUBMIT_ENFORCEMENT_DATE { get; set; }

    public string LEGAL_OA_ASSET_SEARCH { get; set; }

    public DateTime? LEGAL_SUBMIT_INVEST_DATE { get; set; }

    public DateTime? LEGAL_ENFORCEMENT_EFF_DATE { get; set; }

    public DateTime? LEGAL_CASH_RECEIVE_DATE { get; set; }

    public DateTime? LEGAL_SEIZE_DATE { get; set; }

    public DateTime? LEGAL_REPORT_DATE { get; set; }

    public DateTime? LEGAL_JUDGMENT_DATE { get; set; }

    public DateTime? LEGAL_WITHDRAW_DATE { get; set; }

    public DateTime? LEGAL_EXECUTION_DATE { get; set; }

    public DateTime? LEGAL_EXECUTION_END_DATE { get; set; }

    /// <summary>
    /// รายละเอียด
    /// </summary>
    public string LEGAL_DETAILS { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? LEGAL_CREATE_DATE { get; set; }

    /// <summary>
    /// ผู้สร้าง
    /// </summary>
    public string LEGAL_CREATE_BY { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? LEGAL_UPDATE_DATE { get; set; }

    /// <summary>
    /// ผู้แก้ไข
    /// </summary>
    public string LEGAL_UPDATE_BY { get; set; }
}
