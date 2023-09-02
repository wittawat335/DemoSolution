using System;
using System.Collections.Generic;

namespace DemoWebApp.Domain.Entities;

public partial class MG_R3
{
    public string R3_JOB_ID { get; set; }

    public string R3_CUST_CODE { get; set; }

    public string R3_ADDR_ID { get; set; }

    public string R3_CONTRACT_NO { get; set; }

    public string R3_CUST_NAME { get; set; }

    public string R3_CUST_BR_TYPE { get; set; }

    public string R3_CARD_NO { get; set; }

    public string R3_ADDR_FULL { get; set; }

    public DateTime? R3_SEND_DATE { get; set; }

    public DateTime? R3_RECEVIE_DATE { get; set; }

    public DateTime? R3_REJECTED_DATE { get; set; }

    public DateTime? R3_ISSUE_DATE { get; set; }

    public string R3_CASE_STATUS_CODE { get; set; }

    public string R3_CASE_STATUS { get; set; }

    public string R3_EMS_TRACKING { get; set; }

    public DateTime? R3_EXPIRE_DATE { get; set; }

    public DateTime? R3_TARGET_DATE { get; set; }

    public string R3_REMARK { get; set; }

    public string R3_BARCODE { get; set; }

    public string R3_CREATE_BY { get; set; }

    public DateTime? R3_CREATE_DATE { get; set; }

    public string R3_UPDATE_BY { get; set; }

    public DateTime? R3_UPDATE_DATE { get; set; }

    public string R3_STATUS { get; set; }

    public string R3_ADMIN_CODE { get; set; }
}
