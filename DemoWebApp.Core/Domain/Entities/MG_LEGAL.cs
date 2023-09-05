using System;
using System.Collections.Generic;

namespace DemoWebApp.Core.Domain.Entities;

public partial class MG_LEGAL
{
    public string JOB_ID { get; set; }

    public string JOB_CONTRACT_NO { get; set; }

    public string JOB_CASE_CODE { get; set; }

    public string JOB_CASE { get; set; }

    public string JOB_CASE_OTHER { get; set; }

    public string JOB_CASE_TYPE { get; set; }

    public string JOB_LEGAL_STATUS_CODE { get; set; }

    public string JOB_LEGAL_STATUS { get; set; }

    public string JOB_REPO_STATUS_CODE { get; set; }

    public string JOB_REPO_STATUS { get; set; }

    public int? JOB_BASE_COUNT { get; set; }

    public string JOB_REALLOCATE_FLAG { get; set; }

    public string JOB_CUST_CODE { get; set; }

    public string JOB_CUST_NAME { get; set; }

    public string JOB_CUST_TYPE { get; set; }

    public string JOB_CUST_ADDRESS { get; set; }

    public string JOB_CARD_NO { get; set; }

    public string JOB_ADMIN_CODE { get; set; }

    public string JOB_OA_CODE { get; set; }

    public string JOB_OA { get; set; }

    public DateTime? JOB_DUE_DATE { get; set; }

    public int? JOB_DUE_DAY { get; set; }

    public decimal? JOB_INST_AMT { get; set; }

    public decimal? JOB_INST_PAID { get; set; }

    public decimal? JOB_PAID_TERM { get; set; }

    public decimal? JOB_OS_AMT { get; set; }

    public decimal? JOB_OVD_AMT { get; set; }

    public int? JOB_OVD_DAY { get; set; }

    public decimal? JOB_OVD_TERM { get; set; }

    public string JOB_BRAND { get; set; }

    public string JOB_MODEL { get; set; }

    public string JOB_PLATE_NO { get; set; }

    public string JOB_ASSET_DESC { get; set; }

    public DateTime? JOB_EXPIRE_DATE { get; set; }

    public string JOB_DOC_FLAG { get; set; }

    public DateTime? JOB_ASSIGN_ADMIN_DATE { get; set; }

    public DateTime? JOB_ASSIGN_OA_DATE { get; set; }

    public string JOB_ASSIGN_REMARK { get; set; }

    public DateTime? JOB_FILING_DATE { get; set; }

    public string JOB_AML_ORDER_NO { get; set; }

    public DateTime? JOB_AML_ORDER_DATE { get; set; }

    public DateTime? JOB_ANNOUNCE_DATE { get; set; }

    public DateTime? JOB_APPOINT_DATE { get; set; }

    public DateTime? JOB_LAST_DUE_DATE { get; set; }

    public DateTime? JOB_RECEIVE_ORDER_DATE { get; set; }

    public DateTime? JOB_REQUEST_DATE { get; set; }

    public string JOB_CAR_RECEIVE_PLACE { get; set; }

    public DateTime? JOB_CAR_RECEIVE_DATE { get; set; }

    public string JOB_INSURER_NAME { get; set; }

    public string JOB_ORDERED_REH { get; set; }

    public string JOB_PLAINTIFF_NAME { get; set; }

    public string JOB_REMARK { get; set; }

    public string JOB_REQUESTOR { get; set; }

    public string JOB_COMPANY_PLAN { get; set; }

    public decimal? JOB_ASSURED_AMOUNT { get; set; }

    public decimal? JOB_AMOUNT_CLAIMED { get; set; }

    public decimal? JOB_SHORT_FALL { get; set; }

    public decimal? JOB_TOTAL_LOSS_AMOUNT { get; set; }

    public string JOB_CONTRACT_LIST { get; set; }

    public string JOB_CHEQUE_LIST { get; set; }

    public DateTime? JOB_MAILING_DATE { get; set; }

    public string JOB_DEBTOR_STATUS_CODE { get; set; }

    public string JOB_DEBTOR_STATUS { get; set; }

    public string JOB_BLACK_CODE { get; set; }

    public string JOB_RED_CODE { get; set; }

    public string JOB_ATTORNEY_STATUS_CODE { get; set; }

    public string JOB_ATTORNEY_STATUS { get; set; }

    public string JOB_COURT { get; set; }

    public string JOB_COURT_CODE { get; set; }

    public decimal? JOB_COURT_FEE { get; set; }

    public string JOB_POLICE_STATION { get; set; }

    public DateTime? JOB_SUBMISSION_DATE { get; set; }

    public decimal? JOB_SUBMISSION_AMOUNT { get; set; }

    public DateTime? JOB_CONTRACT_TERMINATED_DATE { get; set; }

    public decimal? JOB_LACK_OF_BENEFIT { get; set; }

    public string JOB_CHEQUE_NO { get; set; }

    public DateTime? JOB_NOTIFY_CHEQUE_DATE { get; set; }

    public string JOB_PARTY_IN_LAW_SUIT { get; set; }

    public DateTime? JOB_APPOINTED_DATE { get; set; }

    public DateTime? JOB_ASSIGNED_DATE { get; set; }

    public DateTime? JOB_ATTORNEY_DATE { get; set; }

    public DateTime? JOB_NOTICE_DATE { get; set; }

    public DateTime? JOB_WITNESS_DATE { get; set; }

    public string JOB_WITNESS_TIME { get; set; }

    public decimal? JOB_LAWYER_FEE { get; set; }

    public decimal? JOB_SECOND_LAWYER_FEE { get; set; }

    public DateTime? JOB_ENFORCEMENT_DATE { get; set; }

    public DateTime? JOB_BANKRUPTCY_DATE { get; set; }

    public DateTime? JOB_BANKRUPTCY_DISCHARGED_DATE { get; set; }

    public string JOB_POL_NO { get; set; }

    public string JOB_STOLEN_NO { get; set; }

    public DateTime? JOB_APPOINTMENT_CHECK_DATE { get; set; }

    public string JOB_OA_ENFORCEMENT_CODE { get; set; }

    public string JOB_OA_ENFORCEMENT { get; set; }

    public DateTime? JOB_SUBMIT_ENFORCEMENT_DATE { get; set; }

    public string JOB_OA_ASSET_SEARCH_CODE { get; set; }

    public string JOB_OA_ASSET_SEARCH { get; set; }

    public DateTime? JOB_SUBMIT_INVEST_DATE { get; set; }

    public DateTime? JOB_ENFORCEMENT_EFF_DATE { get; set; }

    public DateTime? JOB_CASH_RECEIVE_DATE { get; set; }

    public DateTime? JOB_SEIZE_DATE { get; set; }

    public DateTime? JOB_REPORT_DATE { get; set; }

    public DateTime? JOB_JUDGMENT_DATE { get; set; }

    public DateTime? JOB_WITHDRAW_DATE { get; set; }

    public DateTime? JOB_EXECUTION_DATE { get; set; }

    public DateTime? JOB_EXECUTION_END_DATE { get; set; }

    public string JOB_DETAILS { get; set; }

    public string JOB_R3_ID { get; set; }

    public DateTime? JOB_STEP_DATE { get; set; }

    public string JOB_CREATE_BY { get; set; }

    public DateTime? JOB_CREATE_DATE { get; set; }

    public string JOB_UPDATE_BY { get; set; }

    public DateTime? JOB_UPDATE_DATE { get; set; }

    public string JOB_STATUS { get; set; }
}
