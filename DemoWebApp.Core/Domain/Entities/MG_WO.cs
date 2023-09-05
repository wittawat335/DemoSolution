using System;
using System.Collections.Generic;

namespace DemoWebApp.Core.Domain.Entities;

public partial class MG_WO
{
    public string WRITEOFFD_HID { get; set; }

    public DateTime? WRITEOFF_DATE { get; set; }

    public string WRITEOFF_TYPE_CODE { get; set; }

    public string WRITEOFF_TYPE { get; set; }

    public string WRITEOFF_SUBTYPE_CODE { get; set; }

    public string WRITEOFF_SUBTYPE { get; set; }

    public string WRITEOFF_APPROVE_FLAG_CODE { get; set; }

    public string WRITEOFF_APPROVE_FLAG { get; set; }

    public string WRITEOFF_APPROVE_BY { get; set; }

    public DateTime? WRITEOFF_APPROVE_DATE { get; set; }

    public string WRITEOFFD_CONTRACT_NO { get; set; }

    public decimal? WRITEOFFD_OS { get; set; }

    public string WRITEOFFD_R3_STATUS_CODE { get; set; }

    public string WRITEOFFD_R3_STATUS { get; set; }

    public int? WRITEOFFD_R3_DAY { get; set; }

    public string WRITEOFFD_REPO_FLAG { get; set; }

    public string WRITEOFFD_AUCTION_FLAG { get; set; }

    public int? WRITEOFFD_OVD_DAY { get; set; }

    public string WRITEOFFD_REDCODE { get; set; }

    public string WRITEOFFD_BLACKCODE { get; set; }

    public string WRITEOFFD_CAIMTAX_STATUS { get; set; }

    public string WRITEOFFD_COMPANY_STATUS { get; set; }

    public string WRITEOFFD_REPO_STATUS_CODE { get; set; }

    public string WRITEOFFD_REPO_STATUS { get; set; }

    public string WRITEOFFD_LEGAL_STATUS_CODE { get; set; }

    public string WRITEOFFD_LEGAL_STATUS { get; set; }

    public DateTime? WRITEOFFD_FILING_DATE { get; set; }

    public string WRITEOFFD_COURTCODE_CODE { get; set; }

    public string WRITEOFFD_COURTCODE { get; set; }

    public DateTime? WRITEOFFD_SUBMIT_ENFORCEMENT_DATE { get; set; }

    public DateTime? WRITEOFFD_SUBMIT_INVEST_DATE { get; set; }

    public DateTime? WRITEOFFD_ENFORCEMENT_EFF_DATE { get; set; }

    public DateTime? WRITEOFFD_REPORT_DATE { get; set; }

    public DateTime? WRITEOFFD_JUDGMENT_DATE { get; set; }

    public DateTime? WRITEOFFD_EXECUTION_DATE { get; set; }

    public DateTime? WRITEOFFD_EXECUTION_END_DATE { get; set; }

    public string WRITEOFFD_REMARK { get; set; }

    public decimal? WRITEOFFD_JD_TOTAL { get; set; }

    public string WRITEOFFD_CREATE_BY { get; set; }

    public DateTime? WRITEOFFD_CREATE_DATE { get; set; }

    public string WRITEOFFD_UPDATE_BY { get; set; }

    public DateTime? WRITEOFFD_UPDATE_DATE { get; set; }

    public string WRITEOFFD_STATUS { get; set; }
}
