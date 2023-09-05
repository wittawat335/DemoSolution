using System;
using System.Collections.Generic;

namespace DemoWebApp.Core.Domain.Entities;

public partial class T_JOB_ALL
{
    public string JOB_CASE_CODE { get; set; }

    public string JOB_CASE_NAME { get; set; }

    public string JOB_CASE_COLOR { get; set; }

    public string JOB_LEGAL_STATUS { get; set; }

    public string JOB_LEGAL_STATUS_NAME { get; set; }

    public string JOB_REPO_STATUS { get; set; }

    public string JOB_REPO_STATUS_NAME { get; set; }

    public string JOB_CASE_STATUS_COLOR { get; set; }

    public string JOB_ID { get; set; }

    public string JOB_CONTRACT_NO { get; set; }

    public string JOB_CHEQUE_LIST { get; set; }

    public string JOB_CONTRACT_LIST { get; set; }

    public string JOB_CUST_CODE { get; set; }

    public string JOB_CUST_NAME { get; set; }

    public string JOB_BRAND { get; set; }

    public string JOB_MODEL { get; set; }

    public string JOB_PLATE_NO { get; set; }

    public decimal? JOB_OS_AMT_COL { get; set; }

    public decimal? JOB_OVD_DAY_COL { get; set; }

    public string JOB_ADMIN_CODE { get; set; }

    public string JOB_ADMIN_NAME { get; set; }

    public DateTime? JOB_ASSIGN_ADMIN_DATE { get; set; }

    public string JOB_OA_CODE { get; set; }

    public string JOB_OA_NAME { get; set; }

    public DateTime? JOB_ASSIGN_OA_DATE { get; set; }

    public DateTime? JOB_STEP_DATE { get; set; }

    public int? JOB_HANDLE_DAY { get; set; }

    public string JOB_DOC_FLAG { get; set; }

    public decimal? JOB_SHORT_FALL { get; set; }

    public decimal? JOB_AMOUNT_CLAIMED { get; set; }

    public string JOB_TYPE { get; set; }

    public DateTime? JOB_FILING_DATE { get; set; }

    public string JOB_CONTRACT_TYPE { get; set; }

    public string JOB_STATUS { get; set; }
}
