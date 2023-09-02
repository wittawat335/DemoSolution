using System;
using System.Collections.Generic;

namespace DemoWebApp.Domain.Entities;

public partial class S_CONTRACT_PMT_RECEIPT
{
    public string CONTRACT_NO { get; set; }

    public int NO_IN_CONTRACT { get; set; }

    public int INVOICE_RECEIPT_INT_ID { get; set; }

    public int? CASH_RECEIPT_ID { get; set; }

    public decimal? AMOUNT_EXCL_VAT { get; set; }

    public decimal? APPLICABLE_WHT_RATE { get; set; }

    public string CLASSIFICATION_CD { get; set; }

    public int? INSTALLMENT_NO { get; set; }

    public DateTime? INVOICE_RECEIPT_DATE { get; set; }

    public string INVOICE_RECEIPT_NO { get; set; }

    public string PAIRED_INVOICE_NUMBER { get; set; }

    public string PAYMENT_CLASSIFICATION_CD { get; set; }

    public DateTime? PROCESSING_DATE { get; set; }

    public string STATUS_CD { get; set; }

    public decimal? VAT_AMOUNT { get; set; }

    public string RECORD_STATUS { get; set; }

    public decimal? PENALTY_CHARGE_AMNT { get; set; }

    public DateTime? DATA_IMPORT_DATE { get; set; }
}
