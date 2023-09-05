using System;
using System.Collections.Generic;

namespace DemoWebApp.Core.Domain.Entities;

public partial class MG_LEGAL_DETAIL
{
    public string CHQ_JOB_ID { get; set; }

    public string CHQ_CHEQUE_NO { get; set; }

    public string CHQ_CONTRACT_NO { get; set; }

    public int? CHQ_SR_NO { get; set; }

    public string CHQ_ACCOUNT_NO { get; set; }

    public string CHQ_BANK_ID { get; set; }

    public string CHQ_BANK_NAME { get; set; }

    public string CHQ_BRANCH_NAME { get; set; }

    public string CHQ_BORROWER_NAME { get; set; }

    public string CHQ_CHEQUE_CLEARING_CODE { get; set; }

    public DateTime? CHQ_DEPOSIT_DATE { get; set; }

    public DateTime? CHQ_UPLOAD_DATE { get; set; }

    public DateTime? CHQ_DUE_DATE { get; set; }

    public decimal? CHQ_EMI_AMOUNT { get; set; }
}
