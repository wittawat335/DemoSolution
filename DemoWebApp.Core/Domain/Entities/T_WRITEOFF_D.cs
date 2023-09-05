using System;
using System.Collections.Generic;

namespace DemoWebApp.Core.Domain.Entities;

public partial class T_WRITEOFF_D
{
    /// <summary>
    /// รหัส Write-off Detail
    /// </summary>
    public int WRITEOFFD_ID { get; set; }

    /// <summary>
    /// T_WRITEOFF_H.WRITEOFF_DOC_ID
    /// </summary>
    public string WRITEOFFD_HID { get; set; }

    /// <summary>
    /// เลขที่สัญญา
    /// </summary>
    public string WRITEOFFD_CONTRACT_NO { get; set; }

    /// <summary>
    /// Outstanding balance
    /// </summary>
    public decimal? WRITEOFFD_OS { get; set; }

    /// <summary>
    /// สถานะการตอบรับจดหมาย R3
    /// </summary>
    public string WRITEOFFD_R3_STATUS { get; set; }

    /// <summary>
    /// จำนวนวันที่ตอบรับจดหมาย R3
    /// </summary>
    public int? WRITEOFFD_R3_DAY { get; set; }

    /// <summary>
    /// สถานะการยึดรถ
    /// </summary>
    public string WRITEOFFD_REPO_FLAG { get; set; }

    /// <summary>
    /// สถานะการขายทอดตลาด
    /// </summary>
    public string WRITEOFFD_AUCTION_FLAG { get; set; }

    /// <summary>
    /// จำนวนวันที่ค้างชำระ
    /// </summary>
    public int? WRITEOFFD_OVD_DAY { get; set; }

    /// <summary>
    /// เลขคดีแดง
    /// </summary>
    public string WRITEOFFD_REDCODE { get; set; }

    /// <summary>
    /// เลขคดีดำ
    /// </summary>
    public string WRITEOFFD_BLACKCODE { get; set; }

    /// <summary>
    /// สถานะ Write off caim tax
    /// </summary>
    public string WRITEOFFD_CAIMTAX_STATUS { get; set; }

    /// <summary>
    /// สถานะ write off company
    /// </summary>
    public string WRITEOFFD_COMPANY_STATUS { get; set; }

    /// <summary>
    /// สถานะการติดตามและยึดรถ
    /// </summary>
    public string WRITEOFFD_REPO_STATUS { get; set; }

    /// <summary>
    /// สถานะทางกฎหมาย
    /// </summary>
    public string WRITEOFFD_LEGAL_STATUS { get; set; }

    /// <summary>
    /// วันที่ฟ้อง
    /// </summary>
    public DateTime? WRITEOFFD_FILING_DATE { get; set; }

    /// <summary>
    /// รหัสศาล
    /// </summary>
    public string WRITEOFFD_COURTCODE { get; set; }

    /// <summary>
    /// วันทีส่งไปบังคับคดี
    /// </summary>
    public DateTime? WRITEOFFD_SUBMIT_ENFORCEMENT_DATE { get; set; }

    /// <summary>
    /// วันที่ส่งไปสืบทรัพย์
    /// </summary>
    public DateTime? WRITEOFFD_SUBMIT_INVEST_DATE { get; set; }

    /// <summary>
    /// วันที่ตั้งเรื่องบังคับคดี
    /// </summary>
    public DateTime? WRITEOFFD_ENFORCEMENT_EFF_DATE { get; set; }

    /// <summary>
    /// วันที่ส่งรายงานสืบทรัพย์
    /// </summary>
    public DateTime? WRITEOFFD_REPORT_DATE { get; set; }

    /// <summary>
    /// วันที่ศาลพิพากษา
    /// </summary>
    public DateTime? WRITEOFFD_JUDGMENT_DATE { get; set; }

    /// <summary>
    /// วันที่บังคับคดี
    /// </summary>
    public DateTime? WRITEOFFD_EXECUTION_DATE { get; set; }

    /// <summary>
    /// วันสิ้นสุดบังคับคดี
    /// </summary>
    public DateTime? WRITEOFFD_EXECUTION_END_DATE { get; set; }

    /// <summary>
    /// หมายเหตุ
    /// </summary>
    public string WRITEOFFD_REMARK { get; set; }

    /// <summary>
    /// หนี้ตามคำพิพากษาไม่รวมดอกเบี้ย
    /// </summary>
    public decimal? WRITEOFFD_JD_TOTAL { get; set; }

    /// <summary>
    /// ผู้สร้าง
    /// </summary>
    public string WRITEOFFD_CREATE_BY { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? WRITEOFFD_CREATE_DATE { get; set; }

    /// <summary>
    /// ผู้แก้ไข
    /// </summary>
    public string WRITEOFFD_UPDATE_BY { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? WRITEOFFD_UPDATE_DATE { get; set; }

    /// <summary>
    /// สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน
    /// </summary>
    public string WRITEOFFD_STATUS { get; set; }
}
