using System;
using System.Collections.Generic;

namespace DemoWebApp.Core.Domain.Entities;

public partial class MG_JDC_D
{
    public int JDD_ID { get; set; }

    public string JDD_CASE_CODE { get; set; }

    public string JDD_CASE { get; set; }

    public string JDD_CONTRACT_NO { get; set; }

    public string JDD_HID { get; set; }

    public string JDD_TRANS_CODE { get; set; }

    public decimal? JDD_AMOUNT { get; set; }

    public decimal? JDD_PAYMENT_AMOUNT { get; set; }

    public string JDD_CREDITBUREAU_FLAG { get; set; }

    public string JDD_SUM_FLAG { get; set; }

    public string JDD_GENERATE_FLAG { get; set; }

    public string JDD_INTEREST_FLAG { get; set; }

    public string JDD_INTEREST_TYPE { get; set; }

    public DateTime? JDD_INTEREST_START_DATE { get; set; }

    public DateTime? JDD_INTEREST_END_DATE { get; set; }

    public string JDD_INTEREST_END_DATE_FLAG { get; set; }

    public int? JDD_INTEREST_MONTHS { get; set; }

    public int? JDD_INTEREST_DAYS { get; set; }

    public decimal? JDD_INTEREST_RATE { get; set; }

    public string JDD_MONTHS_FLAG { get; set; }

    public int? JDD_MONTHS { get; set; }

    public string JDD_REMARK { get; set; }

    public string JDD_CREATE_BY { get; set; }

    public DateTime? JDD_CREATE_DATE { get; set; }

    public string JDD_UPDATE_BY { get; set; }

    public DateTime? JDD_UPDATE_DATE { get; set; }

    public string JDD_STATUS { get; set; }
}
