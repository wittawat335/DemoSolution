using System;
using System.Collections.Generic;

namespace DemoWebApp.Domain.Entities;

public partial class T_ACT_LOG
{
    public long AL_ID { get; set; }

    public string AL_USER_LOGIN { get; set; }

    public string AL_PROG_CODE { get; set; }

    public string AL_DESC { get; set; }

    public DateTime? AC_DATE { get; set; }
}
