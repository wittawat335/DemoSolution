using System;
using System.Collections.Generic;

namespace DemoWebApp.Domain.Entities;

public partial class MG_JD_H
{
    public string JD_ID { get; set; }

    public string JD_CASE_CODE { get; set; }

    public string JD_CASE { get; set; }

    public string JD_CONTRACT_NO { get; set; }

    public string JD_TYPE { get; set; }

    public string JD_JOB_ID { get; set; }

    public string JD_CONTRACT_LIST { get; set; }

    public string JD_CHEQUE_LIST { get; set; }

    public string JD_DEBTOR_STATUS_CODE { get; set; }

    public string JD_DEBTOR_STATUS { get; set; }

    public DateTime? JD_JUDGMENT_DATE { get; set; }

    public DateTime? JD_COMPROMISE_DATE { get; set; }

    public string JD_FURTHER_COMMENT { get; set; }

    public int? JD_TERM { get; set; }

    public decimal? JD_TOTAL { get; set; }

    public DateTime? JD_FIRST_DUE_DATE { get; set; }

    public int? JD_PAY_DAY { get; set; }

    public string JD_APPROVE_FLAG { get; set; }

    public string JD_APPROVE_BY { get; set; }

    public DateTime? JD_APPROVE_DATE { get; set; }

    public string JD_APPROVE_REMARK { get; set; }

    public string JD_REMARK { get; set; }

    public string JD_CREATE_BY { get; set; }

    public DateTime? JD_CREATE_DATE { get; set; }

    public string JD_UPDATE_BY { get; set; }

    public DateTime? JD_UPDATE_DATE { get; set; }

    public string JD_STATUS { get; set; }
}
