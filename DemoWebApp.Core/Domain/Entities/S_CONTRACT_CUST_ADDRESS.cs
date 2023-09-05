using System;
using System.Collections.Generic;

namespace DemoWebApp.Core.Domain.Entities;

public partial class S_CONTRACT_CUST_ADDRESS
{
    public string CONTRACT_NO { get; set; }

    public string CUST_CODE { get; set; }

    public int NO_IN_CUST { get; set; }

    public string ADDRESS_ID { get; set; }

    public string CUST_BR_TYPE { get; set; }

    public string ADDRESS_BUSINESS_ID { get; set; }

    public bool? MAILING_FLG { get; set; }

    public bool? REG_ADDR_FLG { get; set; }

    public string ADDRESS_LINE1 { get; set; }

    public string ADDRESS_LINE2 { get; set; }

    public string ADDRESS_LINE3 { get; set; }

    public string ADDRESS_LINE4 { get; set; }

    public string SUBURB { get; set; }

    public string DISTRICT { get; set; }

    public string CITY { get; set; }

    public string PROVINCE { get; set; }

    public string POSTAL { get; set; }

    public int? PERIOD_STAYED_YRS { get; set; }

    public int? PERIOD_STAYED_MNTS { get; set; }

    public string ADDR_TYPE { get; set; }

    public string OFFICE_TYPE { get; set; }

    public DateTime? DATA_IMPORT_DATE { get; set; }
}
