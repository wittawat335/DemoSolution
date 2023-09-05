using System;
using System.Collections.Generic;

namespace DemoWebApp.Core.Domain.Entities;

public partial class M_OA_CONFIG_AREA
{
    /// <summary>
    /// M_OA.OA_CODE
    /// </summary>
    public string MOA_OA_CODE { get; set; }

    /// <summary>
    /// M_BUCKET.BUCKET_CODE
    /// </summary>
    public string MOA_BUCKET_CODE { get; set; }

    /// <summary>
    /// M_PROVINCE.PROVINCE_CODE
    /// </summary>
    public string MOA_PROVINCE_CODE { get; set; }
}
