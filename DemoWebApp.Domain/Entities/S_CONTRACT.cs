using System;
using System.Collections.Generic;

namespace DemoWebApp.Domain.Entities;

public partial class S_CONTRACT
{
    public string CONTRACT_NO { get; set; }

    public string CONT_CODE { get; set; }

    public string CONTRACT_STATUS { get; set; }

    public string CONTRACT_SUB_STATUS { get; set; }

    public string COLLECTION_STATUS { get; set; }

    public string CONTRACT_TYPE { get; set; }

    public string SUB_PRODUCT { get; set; }

    public int? PAYMENT_TERM { get; set; }

    public int? PAY_DAYS { get; set; }

    public string SERVICE_BRAND { get; set; }

    public string BRAND { get; set; }

    public string MODEL { get; set; }

    public string BODY { get; set; }

    public string PLATE_NO { get; set; }

    public string PLATE_PROVINCE { get; set; }

    public string CHASSIS { get; set; }

    public string COLOR_CD { get; set; }

    public string DL_GROUPNAME { get; set; }

    public string DL_NAME { get; set; }

    public string FI_NAME { get; set; }

    public string SALESMAN_NAME { get; set; }

    public string CUSTOMER_TYPE { get; set; }

    public string CUST_CODE { get; set; }

    public string CUST_NAME_TH { get; set; }

    public string CUST_NAME_EN { get; set; }

    public string ID_NUMBER { get; set; }

    public string PROVINCE_ID { get; set; }

    public string FLEET_CUSTOMER_FLG { get; set; }

    public string ADDRESS_LINE1 { get; set; }

    public string ADDRESS_LINE2 { get; set; }

    public string ADDRESS_LINE3 { get; set; }

    public string BOR_MOBILE_1 { get; set; }

    public string BOR_MOBILE_2 { get; set; }

    public string BOR_BUSINESS_PHONE { get; set; }

    public string BOR_TELEPHONE { get; set; }

    public string GUARANTOR_1 { get; set; }

    public string GUARANTOR_NAME_1 { get; set; }

    public string GUA1_MOBILE_1 { get; set; }

    public string GUA1_MOBILE_2 { get; set; }

    public string GUA1_BUSINESS_PHONE { get; set; }

    public string GUA1_TELEPHONE { get; set; }

    public string GUARANTOR_2 { get; set; }

    public string GUARANTOR_NAME_2 { get; set; }

    public string GUA2_MOBILE_1 { get; set; }

    public string GUA2_MOBILE_2 { get; set; }

    public string GUA2_BUSINESS_PHONE { get; set; }

    public string GUA2_TELEPHONE { get; set; }

    public string NEW_USED { get; set; }

    public decimal? ASSET_PRICE { get; set; }

    public decimal? DOWN_PAYMENT_AMNT { get; set; }

    public decimal? ALL_INSURANCE_FINANCE { get; set; }

    public decimal? TOTAL_FINANCE { get; set; }

    public decimal? TOTAL_INTEREST_AMNT { get; set; }

    public decimal? CONTRACT_TERM { get; set; }

    public decimal? BALLOON_AMNT { get; set; }

    public decimal? ACTUAL_PAYMENT { get; set; }

    public decimal? LAST_PAYMENT_AMOUNT { get; set; }

    public decimal? PAID_AMT { get; set; }

    public decimal? PAID_TERM { get; set; }

    public decimal? OVERDUE_TERM { get; set; }

    public decimal? OVERDUE_DAY { get; set; }

    public DateTime? OVERDUE_DATE { get; set; }

    public string BUCKET_CODE { get; set; }

    public decimal? ARREARS_AMOUNT { get; set; }

    public decimal? OUTSTANDING_BALANCE { get; set; }

    public decimal? OUTSTANDING_TERM { get; set; }

    public DateTime? CONTRACT_CREATION_DATE { get; set; }

    public DateTime? DATA_IMPORT_DATE { get; set; }

    public string COMP_CODE { get; set; }

    public string COMP_BRANCH_CODE { get; set; }
}
