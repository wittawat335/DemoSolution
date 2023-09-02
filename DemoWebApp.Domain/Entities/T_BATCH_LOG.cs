using System;
using System.Collections.Generic;

namespace DemoWebApp.Domain.Entities;

public partial class T_BATCH_LOG
{
    /// <summary>
    /// รหัส Batch Log
    /// </summary>
    public long BATCH_LOG_ID { get; set; }

    /// <summary>
    /// รหัส Batch
    /// </summary>
    public string BATCH_CODE { get; set; }

    /// <summary>
    /// Step Batch
    /// </summary>
    public string BATCH_STEP { get; set; }

    /// <summary>
    /// คำอธิบาย Batch
    /// </summary>
    public string BATCH_DESC { get; set; }

    /// <summary>
    /// สถานะของ batch
    /// </summary>
    public string BATCH_RESULT_FLAG { get; set; }

    /// <summary>
    /// วันที่ batch ทำงาน
    /// </summary>
    public DateTime? BATCH_DATE { get; set; }
}
