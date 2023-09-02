using System;
using System.Collections.Generic;

namespace DemoWebApp.Domain.Entities;

public partial class M_WRITEOFF_SUBTYPE
{
    /// <summary>
    /// รหัส Sub Type
    /// </summary>
    public string SUBTYPE_CODE { get; set; }

    /// <summary>
    /// ชื่อ Sub Type ภาษาไทย
    /// </summary>
    public string SUBTYPE_NAME_TH { get; set; }

    /// <summary>
    /// ชื่อ Sub Type ภาษาอังกฤษ
    /// </summary>
    public string SUBTYPE_NAME_EN { get; set; }

    /// <summary>
    /// รหัส Writeoff Type [M_Master.Master_Code]
    /// </summary>
    public string SUBTYPE_GROUPE_CODE { get; set; }

    /// <summary>
    /// สถานะ Outstanding Balance [0: ไม่มี, 1:มี]
    /// </summary>
    public string SUBTYPE_OS_FLAG { get; set; }

    /// <summary>
    /// Outstanding Balance น้อยสุด
    /// </summary>
    public decimal? SUBTYPE_OS_MIN { get; set; }

    /// <summary>
    /// Outstanding Balance มากสุด
    /// </summary>
    public decimal? SUBTYPE_OS_MAX { get; set; }

    /// <summary>
    /// สถานะการตอบรับจดหมาย R3 [0:ไม่ตอบรับ,1:ตอบรับ]
    /// </summary>
    public string SUBTYPE_R3_FLAG { get; set; }

    /// <summary>
    /// จำนวนวันที่ตอบรับจดหมาย R3
    /// </summary>
    public int? SUBTYPE_R3_DAY { get; set; }

    /// <summary>
    /// สถานะยึดรถ
    /// </summary>
    public string SUBTYPE_REPO_FLAG { get; set; }

    public string SUBTYPE_REPO_STATUS { get; set; }

    /// <summary>
    /// สถานะขายทอดตลาด
    /// </summary>
    public string SUBTYPE_AUCTION_FLAG { get; set; }

    /// <summary>
    /// สถานะวันค้างชำระ
    /// </summary>
    public string SUBTYPE_OVD_FLAG { get; set; }

    /// <summary>
    /// จำนวนวันที่ค้างชำระ
    /// </summary>
    public int? SUBTYPE_OVD_DAY { get; set; }

    /// <summary>
    /// สถานะเลขคดีแดง
    /// </summary>
    public string SUBTYPE_REDCODE { get; set; }

    /// <summary>
    /// สถานะเลขคดีดำ
    /// </summary>
    public string SUBTYPE_BLACKCODE { get; set; }

    /// <summary>
    /// สถานะ Writeoff Caim Tax [0:ไม่มี 1:มี]
    /// </summary>
    public string SUBTYPE_WO_CAIMTAX { get; set; }

    /// <summary>
    /// สถานะ Writeoff Caim Tax Y:เคย N:ไม่เคย
    /// </summary>
    public string SUBTYPE_WO_CAIMTAX_STATUS { get; set; }

    /// <summary>
    /// สถานะ Writeoff Company [0:ไม่มี 1:มี]
    /// </summary>
    public string SUBTYPE_WO_COMP { get; set; }

    /// <summary>
    /// สถานะ Writeoff Company Y:เคย N:ไม่เคย
    /// </summary>
    public string SUBTYPE_WO_COMP_STATUS { get; set; }

    /// <summary>
    /// ผู้สร้าง
    /// </summary>
    public string SUBTYPE_CREATE_BY { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? SUBTYPE_CREATE_DATE { get; set; }

    /// <summary>
    /// ผู้ที่แก้ไข
    /// </summary>
    public string SUBTYPE_UPDATE_BY { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? SUBTYPE_UPDATE_DATE { get; set; }

    /// <summary>
    /// สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน
    /// </summary>
    public string SUBTYPE_STATUS { get; set; }
}
