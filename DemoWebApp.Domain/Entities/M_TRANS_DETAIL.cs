using System;
using System.Collections.Generic;

namespace DemoWebApp.Domain.Entities;

public partial class M_TRANS_DETAIL
{
    public int TRANSD_ID { get; set; }

    public string TRANSD_TRANS_CODE { get; set; }

    public string TRANSD_EXPENSE_FLAG { get; set; }

    public decimal? TRANSD_FROM { get; set; }

    public decimal? TRANSD_TO { get; set; }

    public decimal? TRANSD_VALUE { get; set; }

    public string TRANSD_FIELD { get; set; }
}
