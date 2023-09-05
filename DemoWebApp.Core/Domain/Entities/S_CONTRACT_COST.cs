using System;
using System.Collections.Generic;

namespace DemoWebApp.Core.Domain.Entities;

public partial class S_CONTRACT_COST
{
    public string CONTRACT_NO { get; set; }

    public int COST_SEQ_NO { get; set; }

    public decimal? COST_AMNT { get; set; }

    public string COST_CLASSIFICATION_CD { get; set; }

    public string COST_STATUS_CD { get; set; }

    public string COST_TYPE_CD { get; set; }

    public DateTime? COST_UPLOADED_DATE { get; set; }

    public DateTime? DATE_CHARGED { get; set; }

    public DateTime? DD_DATE { get; set; }

    public string DELETED_BY { get; set; }

    public decimal? OUTSTANDING_COST_AMNT { get; set; }

    public decimal? OUTSTANDING_VAT { get; set; }

    public int? PAYMENT_ID { get; set; }

    public DateTime? RECOVERY_DATE { get; set; }

    public string REMARKS { get; set; }

    public string RETURN_REMARKS { get; set; }

    public string THIRD_PARTY_NAME { get; set; }

    public DateTime? TRANSACTION_DATE { get; set; }

    public decimal? VAT_PAID { get; set; }

    public string RECORD_STATUS { get; set; }

    public DateTime? DATA_IMPORT_DATE { get; set; }
}
