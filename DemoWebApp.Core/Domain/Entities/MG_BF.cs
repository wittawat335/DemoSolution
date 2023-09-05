using System;
using System.Collections.Generic;

namespace DemoWebApp.Core.Domain.Entities;

public partial class MG_BF
{
    public DateTime? BF_DATE { get; set; }

    public string BF_TYPE { get; set; }

    public string BF_APPROVE_FLAG_CODE { get; set; }

    public string BF_APPROVE_FLAG { get; set; }

    public string BF_APPROVE_BY { get; set; }

    public DateTime? BF_APPROVE_DATE { get; set; }

    public string BFD_HID { get; set; }

    public string BFD_CONTRACT_NO { get; set; }

    public string BFD_CARD_NO { get; set; }

    public string BFD_FIRSTNAME { get; set; }

    public string BFD_LASTNAME { get; set; }

    public string BFD_COURTNAME { get; set; }

    public string BFD_REDCODE { get; set; }

    public string BFD_PLAINTIFF_NAME { get; set; }

    public string BFD_DEFENDANT_NAME { get; set; }

    public DateTime? BFD_RECEIVING_ORDER_DATE { get; set; }

    public DateTime? BFD_SUBMIT_DUE_DATE { get; set; }

    public DateTime? BFD_CANCEL_RECEIVING_ORDER_DATE { get; set; }

    public DateTime? BFD_COMPROMISE_BEFORE_DATE { get; set; }

    public DateTime? BFD_CANCEL_COMPROMISE_BAFORE_DATE { get; set; }

    public DateTime? BFD_ORDER_BANKRUPCTY_DATE { get; set; }

    public DateTime? BFD_COMPROMISE_AFTER_DATE { get; set; }

    public DateTime? BFD_CANCEL_COMPROMISE_AFTER_DATE { get; set; }

    public DateTime? BFD_SUBMIT_AFTER_DUE_DATE { get; set; }

    public DateTime? BFD_CANCEL_BANKRUPTCY_DATE { get; set; }

    public DateTime? BFD_DISCHANGED_BANKRUPTCY_DATE { get; set; }

    public DateTime? BFD_DISMISSAL_DATE { get; set; }

    public DateTime? BFD_DISPOSE_CASE_DATE { get; set; }

    public DateTime? BFD_FILING_DATE { get; set; }

    public string BFD_REMARK { get; set; }

    public string BFD_CREATE_BY { get; set; }

    public DateTime? BFD_CREATE_DATE { get; set; }

    public string BFD_UPDATE_BY { get; set; }

    public DateTime? BFD_UPDATE_DATE { get; set; }

    public string BFD_STATUS { get; set; }
}
