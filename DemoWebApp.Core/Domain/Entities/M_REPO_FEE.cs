using System;
using System.Collections.Generic;

namespace DemoWebApp.Core.Domain.Entities;

public partial class M_REPO_FEE
{
    public int REPO_ID { get; set; }

    public int? REPO_OVD_DAY_FROM { get; set; }

    public int? REPO_OVD_DAY_TO { get; set; }

    public string REPO_BRAND { get; set; }

    public string REPO_MODEL { get; set; }

    public string REPO_BODY { get; set; }

    public decimal? REPO_AMT_FROM { get; set; }

    public decimal? REPO_AMT_TO { get; set; }

    public string REPO_FIELD { get; set; }

    public decimal? REPO_AMT { get; set; }
}
