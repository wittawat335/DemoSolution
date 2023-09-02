using System;
using System.Collections.Generic;

namespace DemoWebApp.Domain.Entities;

public partial class S_CONTRACT_PMT_SCHEDULE
{
    public string CONTRACT_NO { get; set; }

    public int PAYMENT_ID { get; set; }

    public string PAYMENT_APPLICATION_STATUS { get; set; }

    public string DELINQUENCY_STATUS { get; set; }

    public decimal? INTEREST_RATE { get; set; }

    public DateTime? CALCULATED_PAYMENT_DATE { get; set; }

    public DateTime? SCHEDULED_PAYMENT_DATE { get; set; }

    public decimal? SCHEDULED_PRINCIPAL_AMNT { get; set; }

    public decimal? SCHEDULED_INTEREST_AMNT { get; set; }

    public decimal? SCHEDULED_SERVICES_AMNT { get; set; }

    public decimal? SCHEDULED_TAX_AMNT { get; set; }

    public decimal? SCHEDULED_FEE_AMNT { get; set; }

    public decimal? UNPAID_PRINCIPAL_BALANCE_AMNT { get; set; }

    public decimal? OUTSTANDING_PRINCIPAL_AMNT { get; set; }

    public decimal? ACCRUED_OUTSTANDING_INTEREST_AMNT { get; set; }

    public decimal? OUTSTANDING_SERVICES_AMNT { get; set; }

    public decimal? OUTSTANDING_TAX_AMNT { get; set; }

    public decimal? OUTSTANDING_FEE_AMNT { get; set; }

    public DateTime? ACTUAL_PAYMENT_DATE { get; set; }

    public decimal? TOTAL_CUST_PAYMENT_AMNT { get; set; }

    public string RECORD_STATUS { get; set; }

    public decimal? BONUS_AMNT { get; set; }

    public DateTime? DATA_IMPORT_DATE { get; set; }
}
