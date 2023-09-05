using System;
using System.Collections.Generic;

namespace DemoWebApp.Core.Domain.Entities;

public partial class M_SIGNATURE
{
    /// <summary>
    /// running number
    /// </summary>
    public int WO_ID { get; set; }

    /// <summary>
    /// ผู้เสนอคนที่ 1 (write off tax &amp; ccompany)
    /// </summary>
    public string WO_C_PROPOSE_1 { get; set; }

    /// <summary>
    /// ผู้เสนอคนที่ 2 (write off tax &amp; ccompany)
    /// </summary>
    public string WO_C_PROPOSE_2 { get; set; }

    /// <summary>
    /// ผู้อนุมัติคนที่ 1 (write off tax &amp; ccompany)
    /// </summary>
    public string WO_C_APPROVED_1 { get; set; }

    /// <summary>
    /// ผู้อนุมัติคนที่ 2 (write off tax &amp; ccompany)
    /// </summary>
    public string WO_C_APPROVED_2 { get; set; }

    /// <summary>
    /// ผู้อนุมัติคนที่ 3 (write off tax &amp; ccompany)
    /// </summary>
    public string WO_C_APPROVED_3 { get; set; }

    /// <summary>
    /// ผู้อนุมัติคนที่ 4 (write off tax &amp; ccompany)
    /// </summary>
    public string WO_C_APPROVED_4 { get; set; }

    /// <summary>
    /// ตำแหน่งผู้เสนอคนที่ 1 (write off tax &amp; ccompany)
    /// </summary>
    public string WO_C_POSITION_1 { get; set; }

    /// <summary>
    /// ตำแหน่งผู้เสนอคนที่ 2 (write off tax &amp; ccompany)
    /// </summary>
    public string WO_C_POSITION_2 { get; set; }

    /// <summary>
    /// ตำแหน่งผู้อนุมัติคนที่ 1 (write off tax &amp; ccompany)
    /// </summary>
    public string WO_C_POSITION_3 { get; set; }

    /// <summary>
    /// ตำแหน่งผู้อนุมัติคนที่ 2 (write off tax &amp; ccompany)
    /// </summary>
    public string WO_C_POSITION_4 { get; set; }

    /// <summary>
    /// ตำแหน่งผู้อนุมัติคนที่ 3 (write off tax &amp; ccompany)
    /// </summary>
    public string WO_C_POSITION_5 { get; set; }

    /// <summary>
    /// ตำแหน่งผู้อนุมัติคนที่ 4 (write off tax &amp; ccompany)
    /// </summary>
    public string WO_C_POSITION_6 { get; set; }

    /// <summary>
    /// ผู้ตรวจสอบคนที่ 1 (write off tax &amp; ccompany)
    /// </summary>
    public string WO_S_REVIEWED_1 { get; set; }

    /// <summary>
    /// ผู้ตรวจสอบคนที่ 2 (write off tax &amp; ccompany)
    /// </summary>
    public string WO_S_REVIEWED_2 { get; set; }

    /// <summary>
    /// ผู้ตรวจสอบคนที่ 3 (write off tax &amp; ccompany)
    /// </summary>
    public string WO_S_REVIEWED_3 { get; set; }

    /// <summary>
    /// ผู้อนุมัติคนที่ 1 (write off from system)
    /// </summary>
    public string WO_S_APPROVED_1 { get; set; }

    /// <summary>
    /// ผู้อนุมัติคนที่ 2 (write off from system)
    /// </summary>
    public string WO_S_APPROVED_2 { get; set; }

    /// <summary>
    /// ผู้อนุมัติคนที่ 3 (write off from system)
    /// </summary>
    public string WO_S_APPROVED_3 { get; set; }

    /// <summary>
    /// ตำแหน่งผู้ตรวจสอบคนที่ 1 (write off from system)
    /// </summary>
    public string WO_S_POSITION_1 { get; set; }

    /// <summary>
    /// ตำแหน่งผู้ตรวจสอบคนที่ 2 (write off from system)
    /// </summary>
    public string WO_S_POSITION_2 { get; set; }

    /// <summary>
    /// ตำแหน่งผู้ตรวจสอบคนที่ 3 (write off from system)
    /// </summary>
    public string WO_S_POSITION_3 { get; set; }

    /// <summary>
    /// ตำแหน่งอนุมัติคนที่ 1 (write off from system)
    /// </summary>
    public string WO_S_POSITION_4 { get; set; }

    /// <summary>
    /// ตำแหน่งอนุมัติคนที่ 2 (write off from system)
    /// </summary>
    public string WO_S_POSITION_5 { get; set; }

    /// <summary>
    /// ตำแหน่งอนุมัติคนที่ 3 (write off from system)
    /// </summary>
    public string WO_S_POSITION_6 { get; set; }
}
