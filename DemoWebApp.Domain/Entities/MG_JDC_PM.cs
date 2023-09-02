using System;
using System.Collections.Generic;

namespace DemoWebApp.Domain.Entities;

public partial class MG_JDC_PM
{
    public string JDP_HID { get; set; }

    public string JDP_CASE_CODE { get; set; }

    public string JDP_CASE { get; set; }

    public string JDP_CONTRACT_NO { get; set; }

    public int? JDP_TERM { get; set; }

    public string JDP_DESCRIPTION { get; set; }

    public DateTime? JDP_DUEDATE { get; set; }

    public decimal? JDP_INSTALLMENT { get; set; }

    public string JDP_CREATE_BY { get; set; }

    public DateTime? JDP_CREATE_DATE { get; set; }

    public string JDP_UPDATE_BY { get; set; }

    public DateTime? JDP_UPDATE_DATE { get; set; }

    public string JDP_STATUS { get; set; }
}
