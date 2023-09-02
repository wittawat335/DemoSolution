using System;
using System.Collections.Generic;

namespace DemoWebApp.Domain.Entities;

public partial class S_CONTRACT_CUST
{
    public string CONTRACT_NO { get; set; }

    public string CUST_CODE { get; set; }

    public string CUST_BR_TYPE { get; set; }

    public int? GUARANTOR_SEQ { get; set; }

    public string SEND_SMS { get; set; }

    public DateTime? DATA_IMPORT_DATE { get; set; }
}
