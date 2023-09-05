using System;
using System.Collections.Generic;

namespace DemoWebApp.Core.Domain.Entities;

public partial class S_CONTRACT_DELINQUENCY
{
    public string CONTRACT_NO { get; set; }

    public int? DELINQUENCY_CYCLE_ID { get; set; }

    public int? PAYMENT_ID { get; set; }

    public string DELINQUENCY_ON_HOLD_STATUS { get; set; }

    public int? DELINQUENCY_STAGE_ID { get; set; }

    public DateTime? OVERDUE_SINCE { get; set; }

    public int? OVERDUE_DAYS { get; set; }

    public int? DELINQUENCY_DAYS { get; set; }

    public DateTime? DELINQUENT_SINCE { get; set; }

    public string DELINQUENCY_REASON_CD { get; set; }

    public int? NO_OF_DELINQUENT_PAYMENTS { get; set; }

    public decimal? TOTAL_DELINQUENT_AMNT { get; set; }

    public string PENALTY_INTEREST_WAIVER_STATUS { get; set; }

    public bool? DELINQUENCY_CLEARED_FG { get; set; }

    public string USER_ALLOCATED { get; set; }

    public string RECORD_STATUS { get; set; }

    public string CREATE_USER { get; set; }

    public DateTime? CREATE_DATE { get; set; }

    public string UPDATE_USER { get; set; }

    public DateTime? UPDATE_DATE { get; set; }

    public decimal? TOTAL_OVERDUE_AMOUNT { get; set; }

    public int? INTERACTION_ID { get; set; }

    public int? DELINQUENCY_SEQUENCE_ID { get; set; }

    public decimal? ARREAR_AMOUNT { get; set; }

    public string STAGE_OFFICER_CHANGED_CD { get; set; }

    public string TRANSMIT_ON_HOLD_CD { get; set; }

    public bool? REMINDER_LETTER1_GENERATED_FLG { get; set; }

    public bool? REMINDER_LETTER2_GENERATED_FLG { get; set; }

    public bool? REMINDER_LETTER3_GENERATED_FLG { get; set; }

    public bool? REMINDER_LETTER4_GENERATED_FLG { get; set; }

    public bool? REMINDER_LETTER5_GENERATED_FLG { get; set; }

    public DateTime? OPRATOR_ASSGN_DATE { get; set; }

    public DateTime? DATA_IMPORT_DATE { get; set; }
}
