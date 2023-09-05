using System;
using System.Collections.Generic;

namespace DemoWebApp.Core.Domain.Entities;

public partial class T_JUDGMENTDEBTOR_ATTACHMENT
{
    public string JDA_HID { get; set; }

    public string JDA_JOB_ID { get; set; }

    public int JDA_SEQUENCE { get; set; }

    public string JDA_FILE_NAME { get; set; }

    public string JDA_FILE_PATH { get; set; }

    public string JDA_DESCRIPTION { get; set; }

    public string JDA_CREATE_BY { get; set; }

    public DateTime? JDA_CREATE_DATE { get; set; }
}
