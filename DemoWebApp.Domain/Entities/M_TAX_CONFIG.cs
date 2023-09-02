using System;
using System.Collections.Generic;

namespace DemoWebApp.Domain.Entities;

public partial class M_TAX_CONFIG
{
    public int TAX_NO { get; set; }

    /// <summary>
    /// ประเภท TAX
    /// </summary>
    public string TAX_TYPE { get; set; }

    /// <summary>
    /// จำนวนเงินเริ่มต้นเสียภาษี
    /// </summary>
    public decimal? TAX_START { get; set; }

    /// <summary>
    /// จำนวนเงินสิ้นสุดเสียภาษี
    /// </summary>
    public decimal? TAX_END { get; set; }

    /// <summary>
    /// เปอร์เซนที่เสียภาษี
    /// </summary>
    public decimal? TAX_RATE { get; set; }

    /// <summary>
    /// ลำดับ
    /// </summary>
    public int? TAX_SEQ { get; set; }

    public DateTime? EFF_FROM_DATE { get; set; }

    public DateTime? EFF_TO_DATE { get; set; }
}
