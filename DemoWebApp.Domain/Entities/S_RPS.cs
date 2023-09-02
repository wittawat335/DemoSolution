using System;
using System.Collections.Generic;

namespace DemoWebApp.Domain.Entities;

public partial class S_RPS
{
    /// <summary>
    /// เลขที่สัญญา
    /// </summary>
    public string RPS_CONTRACT_NO { get; set; }

    /// <summary>
    /// วันที่ออกจดหมาย R3
    /// </summary>
    public DateTime? RPS_R3_DATE { get; set; }

    /// <summary>
    /// วันที่ซื้อคืน
    /// </summary>
    public DateTime? RPS_REMENPTION_DATE { get; set; }

    /// <summary>
    /// ทิมติดตามและยึดรถ
    /// </summary>
    public string RPS_OA { get; set; }

    /// <summary>
    /// สถานะการประมูล
    /// </summary>
    public string RPS_REMARKETING_STATUS { get; set; }

    /// <summary>
    /// วันที่ประมูล
    /// </summary>
    public DateTime? RPS_AUCTION_DATE { get; set; }

    /// <summary>
    /// ราคาประมูล
    /// </summary>
    public decimal? RPS_AUCTION_PRICE_AMT { get; set; }

    /// <summary>
    /// ราคาประมูลรวม vat
    /// </summary>
    public decimal? RPS_AUCTION_PRICE_VAT { get; set; }

    /// <summary>
    /// สถานที่จอดรถ
    /// </summary>
    public string RPS_AUCTION_HOUSE { get; set; }
}
