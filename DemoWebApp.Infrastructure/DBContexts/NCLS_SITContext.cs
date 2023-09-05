using Microsoft.EntityFrameworkCore;
using DemoWebApp.Core.Domain.Entities;

namespace DemoWebApp.Infrastructure.DBContexts;

public partial class NCLS_SITContext : DbContext
{
    public NCLS_SITContext()
    {
    }

    public NCLS_SITContext(DbContextOptions<NCLS_SITContext> options)
        : base(options)
    {
    }

    public virtual DbSet<COL_USER> COL_USER { get; set; }

    public virtual DbSet<COL_USER_CONTRACT> COL_USER_CONTRACT { get; set; }

    public virtual DbSet<MG_BF> MG_BF { get; set; }

    public virtual DbSet<MG_JDC_D> MG_JDC_D { get; set; }

    public virtual DbSet<MG_JDC_H> MG_JDC_H { get; set; }

    public virtual DbSet<MG_JDC_PM> MG_JDC_PM { get; set; }

    public virtual DbSet<MG_JD_D> MG_JD_D { get; set; }

    public virtual DbSet<MG_JD_H> MG_JD_H { get; set; }

    public virtual DbSet<MG_LEGAL> MG_LEGAL { get; set; }

    public virtual DbSet<MG_LEGAL_DETAIL> MG_LEGAL_DETAIL { get; set; }

    public virtual DbSet<MG_R3> MG_R3 { get; set; }

    public virtual DbSet<MG_REPO> MG_REPO { get; set; }

    public virtual DbSet<MG_WO> MG_WO { get; set; }

    public virtual DbSet<M_ACTION> M_ACTION { get; set; }

    public virtual DbSet<M_BUCKET> M_BUCKET { get; set; }

    public virtual DbSet<M_COURT> M_COURT { get; set; }

    public virtual DbSet<M_DOCUMENT> M_DOCUMENT { get; set; }

    public virtual DbSet<M_FUNCTION> M_FUNCTION { get; set; }

    public virtual DbSet<M_LEGAL_CASE> M_LEGAL_CASE { get; set; }

    public virtual DbSet<M_LEGAL_STATUS> M_LEGAL_STATUS { get; set; }

    public virtual DbSet<M_MASTER> M_MASTER { get; set; }

    public virtual DbSet<M_OA> M_OA { get; set; }

    public virtual DbSet<M_OA_CONFIG_AREA> M_OA_CONFIG_AREA { get; set; }

    public virtual DbSet<M_OA_CONFIG_BUCKET> M_OA_CONFIG_BUCKET { get; set; }

    public virtual DbSet<M_OA_GROUP> M_OA_GROUP { get; set; }

    public virtual DbSet<M_PARAMETER> M_PARAMETER { get; set; }

    public virtual DbSet<M_PERMISSION> M_PERMISSION { get; set; }

    public virtual DbSet<M_PROGRAM> M_PROGRAM { get; set; }

    public virtual DbSet<M_PROVINCE> M_PROVINCE { get; set; }

    public virtual DbSet<M_REPO_FEE> M_REPO_FEE { get; set; }

    public virtual DbSet<M_ROLE> M_ROLE { get; set; }

    public virtual DbSet<M_SIGNATURE> M_SIGNATURE { get; set; }

    public virtual DbSet<M_STATUS> M_STATUS { get; set; }

    public virtual DbSet<M_TAX_CONFIG> M_TAX_CONFIG { get; set; }

    public virtual DbSet<M_TRANSACTION> M_TRANSACTION { get; set; }

    public virtual DbSet<M_TRANS_DETAIL> M_TRANS_DETAIL { get; set; }

    public virtual DbSet<M_USER> M_USER { get; set; }

    public virtual DbSet<M_USER_ROLE> M_USER_ROLE { get; set; }

    public virtual DbSet<M_WRITEOFF_SUBTYPE> M_WRITEOFF_SUBTYPE { get; set; }

    public virtual DbSet<S_CONTRACT> S_CONTRACT { get; set; }

    public virtual DbSet<S_CONTRACT_CHEQUE> S_CONTRACT_CHEQUE { get; set; }

    public virtual DbSet<S_CONTRACT_COST> S_CONTRACT_COST { get; set; }

    public virtual DbSet<S_CONTRACT_CUST> S_CONTRACT_CUST { get; set; }

    public virtual DbSet<S_CONTRACT_CUST_ADDRESS> S_CONTRACT_CUST_ADDRESS { get; set; }

    public virtual DbSet<S_CONTRACT_DELINQUENCY> S_CONTRACT_DELINQUENCY { get; set; }

    public virtual DbSet<S_CONTRACT_INTERACTION> S_CONTRACT_INTERACTION { get; set; }

    public virtual DbSet<S_CONTRACT_OVERDUE> S_CONTRACT_OVERDUE { get; set; }

    public virtual DbSet<S_CONTRACT_PMT_RECEIPT> S_CONTRACT_PMT_RECEIPT { get; set; }

    public virtual DbSet<S_CONTRACT_PMT_SCHEDULE> S_CONTRACT_PMT_SCHEDULE { get; set; }

    public virtual DbSet<S_CUSTOMER_DETAIL> S_CUSTOMER_DETAIL { get; set; }

    public virtual DbSet<S_RPS> S_RPS { get; set; }

    public virtual DbSet<T_ACT_LOG> T_ACT_LOG { get; set; }

    public virtual DbSet<T_BANKRUPTCY_FRAUD_D> T_BANKRUPTCY_FRAUD_D { get; set; }

    public virtual DbSet<T_BANKRUPTCY_FRAUD_H> T_BANKRUPTCY_FRAUD_H { get; set; }

    public virtual DbSet<T_BATCH_LOG> T_BATCH_LOG { get; set; }

    public virtual DbSet<T_CHEQUE_DETAIL> T_CHEQUE_DETAIL { get; set; }

    public virtual DbSet<T_CURRENT_LOGIN> T_CURRENT_LOGIN { get; set; }

    public virtual DbSet<T_DOCUMENT> T_DOCUMENT { get; set; }

    public virtual DbSet<T_EXPENSE_D> T_EXPENSE_D { get; set; }

    public virtual DbSet<T_EXPENSE_H> T_EXPENSE_H { get; set; }

    public virtual DbSet<T_JOB_ALL> T_JOB_ALL { get; set; }

    public virtual DbSet<T_JOB_LEGAL> T_JOB_LEGAL { get; set; }

    public virtual DbSet<T_JOB_R3> T_JOB_R3 { get; set; }

    public virtual DbSet<T_JOB_REPO> T_JOB_REPO { get; set; }

    public virtual DbSet<T_JUDGMENTDEBTOR_ATTACHMENT> T_JUDGMENTDEBTOR_ATTACHMENT { get; set; }

    public virtual DbSet<T_JUDGMENTDEBTOR_D> T_JUDGMENTDEBTOR_D { get; set; }

    public virtual DbSet<T_JUDGMENTDEBTOR_H> T_JUDGMENTDEBTOR_H { get; set; }

    public virtual DbSet<T_JUDGMENTDEBTOR_PAYMENT> T_JUDGMENTDEBTOR_PAYMENT { get; set; }

    public virtual DbSet<T_LEGAL_ATTACHMENT> T_LEGAL_ATTACHMENT { get; set; }

    public virtual DbSet<T_LEGAL_TRACKING> T_LEGAL_TRACKING { get; set; }

    public virtual DbSet<T_LOGIN_HISTORY> T_LOGIN_HISTORY { get; set; }

    public virtual DbSet<T_R3_DETAIL> T_R3_DETAIL { get; set; }

    public virtual DbSet<T_REPO_NOTE> T_REPO_NOTE { get; set; }

    public virtual DbSet<T_WRITEOFF_D> T_WRITEOFF_D { get; set; }

    public virtual DbSet<T_WRITEOFF_H> T_WRITEOFF_H { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<COL_USER>(entity =>
        {
            entity.HasKey(e => e.USER_CODE);

            entity.Property(e => e.USER_CODE)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("รหัสผู้ใช้");
            entity.Property(e => e.CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.FIRST_NAME_EN)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("ชื่อภาษาอังกฤษ");
            entity.Property(e => e.FIRST_NAME_TH)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("ชื่อภาษาไทย");
            entity.Property(e => e.LAST_NAME_EN)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("นาสกุลภาษาอังกฤษ");
            entity.Property(e => e.LAST_NAME_TH)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("นามสกุลภาษาไทย");
            entity.Property(e => e.LOGIN_COUNTER).HasComment("จำนวนครั้งที่ Login");
            entity.Property(e => e.UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้แก้ไข");
            entity.Property(e => e.UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
            entity.Property(e => e.USER_GROUP)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("กลุ่มผู้ใช้ Admin,Collector");
            entity.Property(e => e.USER_PASSWORD)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("รหัสผ่าน");
            entity.Property(e => e.USER_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะผู้ใช้ A = Active ,I = Inactive");
        });

        modelBuilder.Entity<COL_USER_CONTRACT>(entity =>
        {
            entity.HasKey(e => new { e.USER_CODE, e.CONTRACT_NO });

            entity.Property(e => e.USER_CODE)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("COL_USER.USER_CODE");
            entity.Property(e => e.CONTRACT_NO)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("S_CONTRACT_DETAIL.CONTRACT_NO");
            entity.Property(e => e.CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้แก้ไข");
            entity.Property(e => e.UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MG_BF>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.BFD_CANCEL_BANKRUPTCY_DATE).HasColumnType("datetime");
            entity.Property(e => e.BFD_CANCEL_COMPROMISE_AFTER_DATE).HasColumnType("datetime");
            entity.Property(e => e.BFD_CANCEL_COMPROMISE_BAFORE_DATE).HasColumnType("datetime");
            entity.Property(e => e.BFD_CANCEL_RECEIVING_ORDER_DATE).HasColumnType("datetime");
            entity.Property(e => e.BFD_CARD_NO)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BFD_COMPROMISE_AFTER_DATE).HasColumnType("datetime");
            entity.Property(e => e.BFD_COMPROMISE_BEFORE_DATE).HasColumnType("datetime");
            entity.Property(e => e.BFD_CONTRACT_NO)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BFD_COURTNAME)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.BFD_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BFD_CREATE_DATE).HasColumnType("datetime");
            entity.Property(e => e.BFD_DEFENDANT_NAME)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.BFD_DISCHANGED_BANKRUPTCY_DATE).HasColumnType("datetime");
            entity.Property(e => e.BFD_DISMISSAL_DATE).HasColumnType("datetime");
            entity.Property(e => e.BFD_DISPOSE_CASE_DATE).HasColumnType("datetime");
            entity.Property(e => e.BFD_FILING_DATE).HasColumnType("datetime");
            entity.Property(e => e.BFD_FIRSTNAME)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.BFD_HID)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BFD_LASTNAME)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.BFD_ORDER_BANKRUPCTY_DATE).HasColumnType("datetime");
            entity.Property(e => e.BFD_PLAINTIFF_NAME)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.BFD_RECEIVING_ORDER_DATE).HasColumnType("datetime");
            entity.Property(e => e.BFD_REDCODE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BFD_REMARK)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.BFD_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.BFD_SUBMIT_AFTER_DUE_DATE).HasColumnType("datetime");
            entity.Property(e => e.BFD_SUBMIT_DUE_DATE).HasColumnType("datetime");
            entity.Property(e => e.BFD_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BFD_UPDATE_DATE).HasColumnType("datetime");
            entity.Property(e => e.BF_APPROVE_BY)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BF_APPROVE_DATE).HasColumnType("datetime");
            entity.Property(e => e.BF_APPROVE_FLAG)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BF_APPROVE_FLAG_CODE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BF_DATE).HasColumnType("datetime");
            entity.Property(e => e.BF_TYPE)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MG_JDC_D>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.JDD_AMOUNT).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.JDD_CASE)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.JDD_CASE_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JDD_CONTRACT_NO)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JDD_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JDD_CREATE_DATE).HasColumnType("datetime");
            entity.Property(e => e.JDD_CREDITBUREAU_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JDD_GENERATE_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JDD_HID)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JDD_ID).ValueGeneratedOnAdd();
            entity.Property(e => e.JDD_INTEREST_END_DATE).HasColumnType("datetime");
            entity.Property(e => e.JDD_INTEREST_END_DATE_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JDD_INTEREST_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JDD_INTEREST_RATE).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.JDD_INTEREST_START_DATE).HasColumnType("datetime");
            entity.Property(e => e.JDD_INTEREST_TYPE)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JDD_MONTHS_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JDD_PAYMENT_AMOUNT).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.JDD_REMARK)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.JDD_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JDD_SUM_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JDD_TRANS_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JDD_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JDD_UPDATE_DATE).HasColumnType("datetime");
        });

        modelBuilder.Entity<MG_JDC_H>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.JD_APPROVE_BY)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JD_APPROVE_DATE).HasColumnType("datetime");
            entity.Property(e => e.JD_APPROVE_FLAG)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JD_APPROVE_FLAG_CODE)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JD_APPROVE_REMARK)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.JD_CASE)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.JD_CASE_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JD_CHEQUE_LIST)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.JD_COMPROMISE_DATE).HasColumnType("datetime");
            entity.Property(e => e.JD_COMPROMIST_TYPE)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.JD_CONTRACT_LIST)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.JD_CONTRACT_NO)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.JD_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JD_CREATE_DATE).HasColumnType("datetime");
            entity.Property(e => e.JD_DEBTOR_STATUS)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.JD_DEBTOR_STATUS_CODE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JD_FIRST_DUE_DATE).HasColumnType("datetime");
            entity.Property(e => e.JD_FURTHER_COMMENT)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.JD_ID)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JD_JOB_ID)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JD_JUDGMENT_DATE).HasColumnType("datetime");
            entity.Property(e => e.JD_REMARK)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.JD_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JD_TOTAL).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JD_TYPE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JD_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JD_UPDATE_DATE).HasColumnType("datetime");
        });

        modelBuilder.Entity<MG_JDC_PM>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.JDP_CASE)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.JDP_CASE_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JDP_CONTRACT_NO)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JDP_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JDP_CREATE_DATE).HasColumnType("datetime");
            entity.Property(e => e.JDP_DESCRIPTION)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.JDP_DUEDATE).HasColumnType("datetime");
            entity.Property(e => e.JDP_HID)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JDP_INSTALLMENT).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JDP_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JDP_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JDP_UPDATE_DATE).HasColumnType("datetime");
        });

        modelBuilder.Entity<MG_JD_D>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.JDD_AMOUNT).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.JDD_CASE)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.JDD_CASE_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JDD_CONTRACT_NO)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JDD_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JDD_CREATE_DATE).HasColumnType("datetime");
            entity.Property(e => e.JDD_CREDITBUREAU_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JDD_GENERATE_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JDD_HID)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JDD_ID).ValueGeneratedOnAdd();
            entity.Property(e => e.JDD_INTEREST_END_DATE).HasColumnType("datetime");
            entity.Property(e => e.JDD_INTEREST_END_DATE_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JDD_INTEREST_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JDD_INTEREST_RATE).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.JDD_INTEREST_START_DATE).HasColumnType("datetime");
            entity.Property(e => e.JDD_INTEREST_TYPE)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JDD_MONTHS_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JDD_PAYMENT_AMOUNT).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.JDD_REMARK)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.JDD_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JDD_SUM_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JDD_TRANS_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JDD_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JDD_UPDATE_DATE).HasColumnType("datetime");
        });

        modelBuilder.Entity<MG_JD_H>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.JD_APPROVE_BY)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JD_APPROVE_DATE).HasColumnType("datetime");
            entity.Property(e => e.JD_APPROVE_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JD_APPROVE_REMARK)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.JD_CASE)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.JD_CASE_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JD_CHEQUE_LIST)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.JD_COMPROMISE_DATE).HasColumnType("datetime");
            entity.Property(e => e.JD_CONTRACT_LIST)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.JD_CONTRACT_NO)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.JD_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JD_CREATE_DATE).HasColumnType("datetime");
            entity.Property(e => e.JD_DEBTOR_STATUS)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.JD_DEBTOR_STATUS_CODE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JD_FIRST_DUE_DATE).HasColumnType("datetime");
            entity.Property(e => e.JD_FURTHER_COMMENT)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.JD_ID)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JD_JOB_ID)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JD_JUDGMENT_DATE).HasColumnType("datetime");
            entity.Property(e => e.JD_REMARK)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.JD_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JD_TOTAL).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JD_TYPE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JD_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JD_UPDATE_DATE).HasColumnType("datetime");
        });

        modelBuilder.Entity<MG_LEGAL>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.JOB_ADMIN_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_AML_ORDER_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_AML_ORDER_NO)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.JOB_AMOUNT_CLAIMED).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_ANNOUNCE_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_APPOINTED_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_APPOINTMENT_CHECK_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_APPOINT_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_ASSET_DESC)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.JOB_ASSIGNED_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_ASSIGN_ADMIN_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_ASSIGN_OA_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_ASSIGN_REMARK)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.JOB_ASSURED_AMOUNT).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_ATTORNEY_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_ATTORNEY_STATUS)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.JOB_ATTORNEY_STATUS_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_BANKRUPTCY_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_BANKRUPTCY_DISCHARGED_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_BLACK_CODE)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.JOB_BRAND)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CARD_NO)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CAR_RECEIVE_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_CAR_RECEIVE_PLACE)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CASE)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CASE_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CASE_OTHER)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CASE_TYPE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CASH_RECEIVE_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_CHEQUE_LIST)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CHEQUE_NO)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.JOB_COMPANY_PLAN)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CONTRACT_LIST)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CONTRACT_NO)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CONTRACT_TERMINATED_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_COURT)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.JOB_COURT_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_COURT_FEE).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CREATE_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_CUST_ADDRESS)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CUST_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CUST_NAME)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CUST_TYPE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_DEBTOR_STATUS)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.JOB_DEBTOR_STATUS_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_DETAILS)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.JOB_DOC_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JOB_DUE_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_ENFORCEMENT_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_ENFORCEMENT_EFF_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_EXECUTION_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_EXECUTION_END_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_EXPIRE_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_FILING_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_ID)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_INST_AMT).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_INST_PAID).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_INSURER_NAME)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.JOB_JUDGMENT_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_LACK_OF_BENEFIT).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_LAST_DUE_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_LAWYER_FEE).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_LEGAL_STATUS)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.JOB_LEGAL_STATUS_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_MAILING_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_MODEL)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.JOB_NOTICE_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_NOTIFY_CHEQUE_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_OA)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.JOB_OA_ASSET_SEARCH)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.JOB_OA_ASSET_SEARCH_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_OA_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_OA_ENFORCEMENT)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JOB_OA_ENFORCEMENT_CODE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JOB_ORDERED_REH)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.JOB_OS_AMT).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_OVD_AMT).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_OVD_TERM).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_PAID_TERM).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_PARTY_IN_LAW_SUIT)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.JOB_PLAINTIFF_NAME)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.JOB_PLATE_NO)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.JOB_POLICE_STATION)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.JOB_POL_NO)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.JOB_R3_ID)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_REALLOCATE_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JOB_RECEIVE_ORDER_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_RED_CODE)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.JOB_REMARK)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.JOB_REPORT_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_REPO_STATUS)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.JOB_REPO_STATUS_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_REQUESTOR)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.JOB_REQUEST_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_SECOND_LAWYER_FEE).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_SEIZE_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_SHORT_FALL).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JOB_STEP_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_STOLEN_NO)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.JOB_SUBMISSION_AMOUNT).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_SUBMISSION_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_SUBMIT_ENFORCEMENT_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_SUBMIT_INVEST_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_TOTAL_LOSS_AMOUNT).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JOB_UPDATE_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_WITHDRAW_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_WITNESS_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_WITNESS_TIME)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MG_LEGAL_DETAIL>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CHQ_ACCOUNT_NO)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CHQ_BANK_ID)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CHQ_BANK_NAME)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CHQ_BORROWER_NAME)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CHQ_BRANCH_NAME)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CHQ_CHEQUE_CLEARING_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CHQ_CHEQUE_NO)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CHQ_CONTRACT_NO)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CHQ_DEPOSIT_DATE).HasColumnType("datetime");
            entity.Property(e => e.CHQ_DUE_DATE).HasColumnType("datetime");
            entity.Property(e => e.CHQ_EMI_AMOUNT).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CHQ_JOB_ID)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CHQ_UPLOAD_DATE).HasColumnType("datetime");
        });

        modelBuilder.Entity<MG_R3>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.R3_ADDR_FULL)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.R3_ADDR_ID)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.R3_ADMIN_CODE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.R3_BARCODE)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.R3_CARD_NO)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.R3_CASE_STATUS)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.R3_CASE_STATUS_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.R3_CONTRACT_NO)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.R3_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.R3_CREATE_DATE).HasColumnType("datetime");
            entity.Property(e => e.R3_CUST_BR_TYPE)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.R3_CUST_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.R3_CUST_NAME)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.R3_EMS_TRACKING)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.R3_EXPIRE_DATE).HasColumnType("datetime");
            entity.Property(e => e.R3_ISSUE_DATE).HasColumnType("datetime");
            entity.Property(e => e.R3_JOB_ID)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.R3_RECEVIE_DATE).HasColumnType("datetime");
            entity.Property(e => e.R3_REJECTED_DATE).HasColumnType("datetime");
            entity.Property(e => e.R3_REMARK)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.R3_SEND_DATE).HasColumnType("datetime");
            entity.Property(e => e.R3_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.R3_TARGET_DATE).HasColumnType("datetime");
            entity.Property(e => e.R3_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.R3_UPDATE_DATE).HasColumnType("datetime");
        });

        modelBuilder.Entity<MG_REPO>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.JOB_ADMIN_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_ASSET_DESC)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.JOB_ASSIGN_ADMIN_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_ASSIGN_OA_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_ASSIGN_REMARK)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.JOB_BRAND)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.JOB_BUCKET)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CARD_NO)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CAR_PARK)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CAR_PARK_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CASE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CHARGE_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_CONTRACT_NO)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CREATE_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_CUST_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CUST_NAME)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CUST_TYPE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_DOC_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JOB_DUE_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_EXPIRE_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_FEE_EXPENSE).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.JOB_ID)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_INST_AMT).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.JOB_INST_PAID).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.JOB_LEGAL_STATUS)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.JOB_LEGAL_STATUS_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_MILEAGE).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.JOB_MODEL)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.JOB_NOTI_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JOB_OA)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.JOB_OA_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_OA_SUCCESS)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.JOB_OA_SUCCESS_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_OS_AMT).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.JOB_OTHER_EXPENSE).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.JOB_OVD_AMT).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.JOB_OVD_TERM).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.JOB_PAID_TERM).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.JOB_PLATE_NO)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.JOB_PROVINCE_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_R3_ID)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_R3_RECEVIE_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_R3_SEND_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_REALLOCATE_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JOB_RECEIVE_REMARK)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.JOB_REPO_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_REPO_EXPENSE).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.JOB_REPO_STATUS).HasMaxLength(200);
            entity.Property(e => e.JOB_REPO_STATUS_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_REPO_TYPE)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.JOB_REPO_TYPE_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_RPS_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JOB_STEP_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_TRANS_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JOB_UPDATE_DATE).HasColumnType("datetime");
        });

        modelBuilder.Entity<MG_WO>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.WRITEOFFD_AUCTION_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.WRITEOFFD_BLACKCODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.WRITEOFFD_CAIMTAX_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.WRITEOFFD_COMPANY_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.WRITEOFFD_CONTRACT_NO)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.WRITEOFFD_COURTCODE)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.WRITEOFFD_COURTCODE_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.WRITEOFFD_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WRITEOFFD_CREATE_DATE).HasColumnType("datetime");
            entity.Property(e => e.WRITEOFFD_ENFORCEMENT_EFF_DATE).HasColumnType("datetime");
            entity.Property(e => e.WRITEOFFD_EXECUTION_DATE).HasColumnType("datetime");
            entity.Property(e => e.WRITEOFFD_EXECUTION_END_DATE).HasColumnType("datetime");
            entity.Property(e => e.WRITEOFFD_FILING_DATE).HasColumnType("datetime");
            entity.Property(e => e.WRITEOFFD_HID)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.WRITEOFFD_JD_TOTAL).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.WRITEOFFD_JUDGMENT_DATE).HasColumnType("datetime");
            entity.Property(e => e.WRITEOFFD_LEGAL_STATUS)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.WRITEOFFD_LEGAL_STATUS_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.WRITEOFFD_OS).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.WRITEOFFD_R3_STATUS)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.WRITEOFFD_R3_STATUS_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.WRITEOFFD_REDCODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.WRITEOFFD_REMARK)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.WRITEOFFD_REPORT_DATE).HasColumnType("datetime");
            entity.Property(e => e.WRITEOFFD_REPO_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.WRITEOFFD_REPO_STATUS)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.WRITEOFFD_REPO_STATUS_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.WRITEOFFD_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.WRITEOFFD_SUBMIT_ENFORCEMENT_DATE).HasColumnType("datetime");
            entity.Property(e => e.WRITEOFFD_SUBMIT_INVEST_DATE).HasColumnType("datetime");
            entity.Property(e => e.WRITEOFFD_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WRITEOFFD_UPDATE_DATE).HasColumnType("datetime");
            entity.Property(e => e.WRITEOFF_APPROVE_BY)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WRITEOFF_APPROVE_DATE).HasColumnType("datetime");
            entity.Property(e => e.WRITEOFF_APPROVE_FLAG)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WRITEOFF_APPROVE_FLAG_CODE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WRITEOFF_DATE).HasColumnType("datetime");
            entity.Property(e => e.WRITEOFF_SUBTYPE)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.WRITEOFF_SUBTYPE_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.WRITEOFF_TYPE)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.WRITEOFF_TYPE_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<M_ACTION>(entity =>
        {
            entity.HasKey(e => e.ACT_CODE);

            entity.Property(e => e.ACT_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัสแอคชั่น");
            entity.Property(e => e.ACT_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.ACT_CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.ACT_NAME)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อแอคชั่น");
            entity.Property(e => e.ACT_PROG_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("M_Function.Func_Code");
            entity.Property(e => e.ACT_STATUS)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน");
            entity.Property(e => e.ACT_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้ที่แก้ไข");
            entity.Property(e => e.ACT_UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<M_BUCKET>(entity =>
        {
            entity.HasKey(e => e.BUCKET_CODE);

            entity.Property(e => e.BUCKET_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัสระดับการติดตาม (Bucket)");
            entity.Property(e => e.BUCKET_BRANCH_CODE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BUCKET_COMP_CODE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BUCKET_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.BUCKET_CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.BUCKET_DESC)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("รายละเอียดระดับการติดตาม (Bucket)");
            entity.Property(e => e.BUCKET_NAME)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ชื่อระดับการติดตาม (Bucket)");
            entity.Property(e => e.BUCKET_OVDDAYS_END).HasComment("จำนวนวันค้างชำระสิ้นสุด");
            entity.Property(e => e.BUCKET_OVDDAYS_START).HasComment("จำนวนวันค้างชำระสิ้นสุด");
            entity.Property(e => e.BUCKET_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน");
            entity.Property(e => e.BUCKET_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้แก้ไข");
            entity.Property(e => e.BUCKET_UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<M_COURT>(entity =>
        {
            entity.HasKey(e => e.COURT_CODE);

            entity.Property(e => e.COURT_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัสศาล");
            entity.Property(e => e.COURT_AMT)
                .HasComment("จำนวนค่าธรรมเนียมศาล")
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.COURT_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.COURT_CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.COURT_NAME_EN)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่ออังกฤษ");
            entity.Property(e => e.COURT_NAME_TH)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อไทย");
            entity.Property(e => e.COURT_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน");
            entity.Property(e => e.COURT_TYPE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("ประเภทศาล");
            entity.Property(e => e.COURT_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้แก้ไข");
            entity.Property(e => e.COURT_UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<M_DOCUMENT>(entity =>
        {
            entity.HasKey(e => new { e.DOC_CASE_CODE, e.DOC_CODE });

            entity.Property(e => e.DOC_CASE_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("M_Master.Master_Code [MasterInfoType=LCTP]");
            entity.Property(e => e.DOC_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("M_Master.Master_Code [MasterInfoType=DOTP]");
            entity.Property(e => e.DOC_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.DOC_CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.DOC_REQ_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะ");
            entity.Property(e => e.DOC_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน");
            entity.Property(e => e.DOC_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้แก้ไข");
            entity.Property(e => e.DOC_UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<M_FUNCTION>(entity =>
        {
            entity.HasKey(e => e.FUNC_CODE);

            entity.Property(e => e.FUNC_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัสฟังชั่น");
            entity.Property(e => e.FUNC_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.FUNC_CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.FUNC_NAME)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อฟังชั่น");
            entity.Property(e => e.FUNC_PROG_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("M_Program.Prog_Code");
            entity.Property(e => e.FUNC_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน");
            entity.Property(e => e.FUNC_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้แก้ไข");
            entity.Property(e => e.FUNC_UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<M_LEGAL_CASE>(entity =>
        {
            entity.HasKey(e => e.CASE_CODE).HasName("PK_LEGAL_CASE");

            entity.Property(e => e.CASE_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัส Case");
            entity.Property(e => e.CASE_COLOR)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("รหัสสี");
            entity.Property(e => e.CASE_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.CASE_CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.CASE_DOC_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะเอกสาร");
            entity.Property(e => e.CASE_GROUP_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัสประเภทกลุ่มคดี");
            entity.Property(e => e.CASE_NAME_EN)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อกรณีทางกฎหมาย ภาษาอังกฤษ");
            entity.Property(e => e.CASE_NAME_TH)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อกรณีทางกฎหมาย ภาษาไทย");
            entity.Property(e => e.CASE_SEQ).HasComment("ลำดับ");
            entity.Property(e => e.CASE_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะข้อมูล A=Active,I=Inactive");
            entity.Property(e => e.CASE_TABLE)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ที่เก็บข้อมูล");
            entity.Property(e => e.CASE_TYPE)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ประเภทการฟ้อง [Contract, Cheque]");
            entity.Property(e => e.CASE_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้แก้ไข");
            entity.Property(e => e.CASE_UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<M_LEGAL_STATUS>(entity =>
        {
            entity.HasKey(e => new { e.LGSTS_CASE_CODE, e.LGSTS_STS_CODE });

            entity.Property(e => e.LGSTS_CASE_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("CaseLegal ผูกกับ สถานะ M_Master.Master_Code [MasterInfoType=LCTP]");
            entity.Property(e => e.LGSTS_STS_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("M_Status.Sts_Code");
            entity.Property(e => e.LGSTS_COLOR_1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("รหัสสี 1");
            entity.Property(e => e.LGSTS_COLOR_2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("รหัสสี 2");
            entity.Property(e => e.LGSTS_COLOR_3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("รหัสสี 3");
            entity.Property(e => e.LGSTS_COLOR_4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("รหัสสี 4");
            entity.Property(e => e.LGSTS_COLOR_5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("รหัสสี 5");
            entity.Property(e => e.LGSTS_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.LGSTS_CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.LGSTS_END_1).HasComment("จำนวนสิ้นสุด 1");
            entity.Property(e => e.LGSTS_END_2).HasComment("จำนวนสิ้นสุด 2");
            entity.Property(e => e.LGSTS_END_3).HasComment("จำนวนสิ้นสุด 3");
            entity.Property(e => e.LGSTS_END_4).HasComment("จำนวนสิ้นสุด 4");
            entity.Property(e => e.LGSTS_END_5).HasComment("จำนวนสิ้นสุด 5");
            entity.Property(e => e.LGSTS_START_1).HasComment("จำนวนเริ่มต้น 1");
            entity.Property(e => e.LGSTS_START_2).HasComment("จำนวนเริ่มต้น 2");
            entity.Property(e => e.LGSTS_START_3).HasComment("จำนวนเริ่มต้น 3");
            entity.Property(e => e.LGSTS_START_4).HasComment("จำนวนเริ่มต้น 4");
            entity.Property(e => e.LGSTS_START_5).HasComment("จำนวนเริ่มต้น 5");
            entity.Property(e => e.LGSTS_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน");
            entity.Property(e => e.LGSTS_SUCC_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะ สำเร็จ");
            entity.Property(e => e.LGSTS_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้แก้ไข");
            entity.Property(e => e.LGSTS_UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<M_MASTER>(entity =>
        {
            entity.HasKey(e => new { e.MASTER_CODE, e.MASTER_TYPE });

            entity.Property(e => e.MASTER_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัส");
            entity.Property(e => e.MASTER_TYPE)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ประเภท");
            entity.Property(e => e.MASTER_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.MASTER_CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.MASTER_NAME_EN)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่ออังกฤษ");
            entity.Property(e => e.MASTER_NAME_TH)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อไทย");
            entity.Property(e => e.MASTER_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะ");
            entity.Property(e => e.MASTER_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้แก้ไข");
            entity.Property(e => e.MASTER_UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<M_OA>(entity =>
        {
            entity.HasKey(e => e.OA_CODE);

            entity.Property(e => e.OA_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัส OA");
            entity.Property(e => e.OA_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.OA_CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.OA_GROUP_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("M_OutsourceGroup.OutsGroup_Code");
            entity.Property(e => e.OA_LEGAL_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.OA_NAME_EN)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่ออังกฤษ");
            entity.Property(e => e.OA_NAME_TH)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อไทย");
            entity.Property(e => e.OA_REPO_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.OA_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน");
            entity.Property(e => e.OA_TYPE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OA_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้แก้ไข");
            entity.Property(e => e.OA_UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<M_OA_CONFIG_AREA>(entity =>
        {
            entity.HasKey(e => new { e.MOA_OA_CODE, e.MOA_BUCKET_CODE, e.MOA_PROVINCE_CODE });

            entity.Property(e => e.MOA_OA_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("M_OA.OA_CODE");
            entity.Property(e => e.MOA_BUCKET_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("M_BUCKET.BUCKET_CODE");
            entity.Property(e => e.MOA_PROVINCE_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("M_PROVINCE.PROVINCE_CODE");
        });

        modelBuilder.Entity<M_OA_CONFIG_BUCKET>(entity =>
        {
            entity.HasKey(e => new { e.MOB_OA_CODE, e.MOB_BUCKET_CODE }).HasName("PK_M_MAPPING_OA");

            entity.Property(e => e.MOB_OA_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("M_OA.OA_CODE");
            entity.Property(e => e.MOB_BUCKET_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("M_PROVINCE.Province_Id");
            entity.Property(e => e.MOB_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.MOB_CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.MOB_LIMIT_JOBS).HasComment("จำนวนงานสูงสุด");
            entity.Property(e => e.MOB_LIMIT_PERCENTAGE).HasComment("จำนวนเปอร์เซนต์สูงสุด");
            entity.Property(e => e.MOB_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน");
            entity.Property(e => e.MOB_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้แก้ไข");
            entity.Property(e => e.MOB_UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<M_OA_GROUP>(entity =>
        {
            entity.HasKey(e => e.OAGROUP_CODE);

            entity.Property(e => e.OAGROUP_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัสกลุ่ม OA");
            entity.Property(e => e.OAGROUP_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.OAGROUP_CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.OAGROUP_EXPIRED_DAY).HasComment("วันหมดอายุ");
            entity.Property(e => e.OAGROUP_NAME_EN)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่ออังกฤษ");
            entity.Property(e => e.OAGROUP_NAME_TH)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อไทย");
            entity.Property(e => e.OAGROUP_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน");
            entity.Property(e => e.OAGROUP_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้แก้ไข");
            entity.Property(e => e.OAGROUP_UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<M_PARAMETER>(entity =>
        {
            entity.HasKey(e => e.PARA_CODE);

            entity.Property(e => e.PARA_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัส");
            entity.Property(e => e.PARA_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.PARA_CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.PARA_DATA_TYPE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("ประเภทข้อมูล");
            entity.Property(e => e.PARA_DEFAULT_VALUE)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ค่าเริ่มต้น");
            entity.Property(e => e.PARA_DESC)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("คำอธิบาย Parameter");
            entity.Property(e => e.PARA_NAME)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อ");
            entity.Property(e => e.PARA_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะข้อมูล");
            entity.Property(e => e.PARA_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้แก้ไข");
            entity.Property(e => e.PARA_UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
            entity.Property(e => e.PARA_VALUE)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ค่า");
        });

        modelBuilder.Entity<M_PERMISSION>(entity =>
        {
            entity.HasKey(e => new { e.PERM_ROLE_CODE, e.PERM_PROG_CODE, e.PERM_ACT_CODE }).HasName("PK_M_PERMISSION_1");

            entity.Property(e => e.PERM_ROLE_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("M_Role.Role_Code");
            entity.Property(e => e.PERM_PROG_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("M_Program.Prog_Code");
            entity.Property(e => e.PERM_ACT_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("M_Action.Act_Code");
            entity.Property(e => e.PERM_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.PERM_CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.PERM_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน");
            entity.Property(e => e.PERM_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้แก้ไข");
            entity.Property(e => e.PERM_UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
            entity.Property(e => e.PERM_USE_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Default 1");
        });

        modelBuilder.Entity<M_PROGRAM>(entity =>
        {
            entity.HasKey(e => e.PROG_CODE);

            entity.Property(e => e.PROG_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัสโปรแกรม");
            entity.Property(e => e.PROG_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.PROG_CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.PROG_ICON)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ชื่อ icon");
            entity.Property(e => e.PROG_LEVEL).HasComment("เลเวล");
            entity.Property(e => e.PROG_NAME)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อโปรแกรม");
            entity.Property(e => e.PROG_ORDER).HasComment("เรียงลำดับ");
            entity.Property(e => e.PROG_PARENT_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("เป็นลูกของโปรแกรม");
            entity.Property(e => e.PROG_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน");
            entity.Property(e => e.PROG_TARGET_URL)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("Url");
            entity.Property(e => e.PROG_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้แก้ไข");
            entity.Property(e => e.PROG_UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<M_PROVINCE>(entity =>
        {
            entity.HasKey(e => e.PROVINCE_CODE);

            entity.Property(e => e.PROVINCE_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัสจังหวัด");
            entity.Property(e => e.PROVINCE_CREATEBY)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.PROVINCE_CREATEDATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.PROVINCE_GEOGRAPHYCODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัสภูมิศาสตร์");
            entity.Property(e => e.PROVINCE_NAME)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อจังหวัด");
            entity.Property(e => e.PROVINCE_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน");
            entity.Property(e => e.PROVINCE_UPDATEBY)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ผู้แก้ไข");
            entity.Property(e => e.PROVINCE_UPDATEDATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<M_REPO_FEE>(entity =>
        {
            entity.HasKey(e => e.REPO_ID);

            entity.Property(e => e.REPO_AMT).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.REPO_AMT_FROM).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.REPO_AMT_TO).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.REPO_BODY)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.REPO_BRAND)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.REPO_FIELD)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.REPO_MODEL)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<M_ROLE>(entity =>
        {
            entity.HasKey(e => e.ROLE_CODE);

            entity.Property(e => e.ROLE_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัสสิทธิ์");
            entity.Property(e => e.ROLE_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.ROLE_CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.ROLE_DATA_LEVEL).HasComment("ระดับการเข้าถึงข้อมูล");
            entity.Property(e => e.ROLE_NAME)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อสิทธิ์");
            entity.Property(e => e.ROLE_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน");
            entity.Property(e => e.ROLE_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้แก้ไข");
            entity.Property(e => e.ROLE_UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<M_SIGNATURE>(entity =>
        {
            entity.HasKey(e => e.WO_ID);

            entity.Property(e => e.WO_ID).HasComment("running number");
            entity.Property(e => e.WO_C_APPROVED_1)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ผู้อนุมัติคนที่ 1 (write off tax & ccompany)");
            entity.Property(e => e.WO_C_APPROVED_2)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ผู้อนุมัติคนที่ 2 (write off tax & ccompany)");
            entity.Property(e => e.WO_C_APPROVED_3)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ผู้อนุมัติคนที่ 3 (write off tax & ccompany)");
            entity.Property(e => e.WO_C_APPROVED_4)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ผู้อนุมัติคนที่ 4 (write off tax & ccompany)");
            entity.Property(e => e.WO_C_POSITION_1)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ตำแหน่งผู้เสนอคนที่ 1 (write off tax & ccompany)");
            entity.Property(e => e.WO_C_POSITION_2)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ตำแหน่งผู้เสนอคนที่ 2 (write off tax & ccompany)");
            entity.Property(e => e.WO_C_POSITION_3)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ตำแหน่งผู้อนุมัติคนที่ 1 (write off tax & ccompany)");
            entity.Property(e => e.WO_C_POSITION_4)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ตำแหน่งผู้อนุมัติคนที่ 2 (write off tax & ccompany)");
            entity.Property(e => e.WO_C_POSITION_5)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ตำแหน่งผู้อนุมัติคนที่ 3 (write off tax & ccompany)");
            entity.Property(e => e.WO_C_POSITION_6)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ตำแหน่งผู้อนุมัติคนที่ 4 (write off tax & ccompany)");
            entity.Property(e => e.WO_C_PROPOSE_1)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ผู้เสนอคนที่ 1 (write off tax & ccompany)");
            entity.Property(e => e.WO_C_PROPOSE_2)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ผู้เสนอคนที่ 2 (write off tax & ccompany)");
            entity.Property(e => e.WO_S_APPROVED_1)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ผู้อนุมัติคนที่ 1 (write off from system)");
            entity.Property(e => e.WO_S_APPROVED_2)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ผู้อนุมัติคนที่ 2 (write off from system)");
            entity.Property(e => e.WO_S_APPROVED_3)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ผู้อนุมัติคนที่ 3 (write off from system)");
            entity.Property(e => e.WO_S_POSITION_1)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ตำแหน่งผู้ตรวจสอบคนที่ 1 (write off from system)");
            entity.Property(e => e.WO_S_POSITION_2)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ตำแหน่งผู้ตรวจสอบคนที่ 2 (write off from system)");
            entity.Property(e => e.WO_S_POSITION_3)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ตำแหน่งผู้ตรวจสอบคนที่ 3 (write off from system)");
            entity.Property(e => e.WO_S_POSITION_4)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ตำแหน่งอนุมัติคนที่ 1 (write off from system)");
            entity.Property(e => e.WO_S_POSITION_5)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ตำแหน่งอนุมัติคนที่ 2 (write off from system)");
            entity.Property(e => e.WO_S_POSITION_6)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ตำแหน่งอนุมัติคนที่ 3 (write off from system)");
            entity.Property(e => e.WO_S_REVIEWED_1)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ผู้ตรวจสอบคนที่ 1 (write off tax & ccompany)");
            entity.Property(e => e.WO_S_REVIEWED_2)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ผู้ตรวจสอบคนที่ 2 (write off tax & ccompany)");
            entity.Property(e => e.WO_S_REVIEWED_3)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ผู้ตรวจสอบคนที่ 3 (write off tax & ccompany)");
        });

        modelBuilder.Entity<M_STATUS>(entity =>
        {
            entity.HasKey(e => e.STS_CODE);

            entity.Property(e => e.STS_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัสสถานะ");
            entity.Property(e => e.STS_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.STS_CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.STS_NAME_EN)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่ออังกฤษ");
            entity.Property(e => e.STS_NAME_TH)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อไทย");
            entity.Property(e => e.STS_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน");
            entity.Property(e => e.STS_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้แก้ไข");
            entity.Property(e => e.STS_UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<M_TAX_CONFIG>(entity =>
        {
            entity.HasKey(e => e.TAX_NO);

            entity.Property(e => e.EFF_FROM_DATE).HasColumnType("datetime");
            entity.Property(e => e.EFF_TO_DATE).HasColumnType("datetime");
            entity.Property(e => e.TAX_END)
                .HasComment("จำนวนเงินสิ้นสุดเสียภาษี")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TAX_RATE)
                .HasComment("เปอร์เซนที่เสียภาษี")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TAX_SEQ).HasComment("ลำดับ");
            entity.Property(e => e.TAX_START)
                .HasComment("จำนวนเงินเริ่มต้นเสียภาษี")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TAX_TYPE)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ประเภท TAX");
        });

        modelBuilder.Entity<M_TRANSACTION>(entity =>
        {
            entity.HasKey(e => new { e.TRANS_CODE, e.TRANS_GROUP_CODE });

            entity.Property(e => e.TRANS_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัสรายการ รายการชำระ ");
            entity.Property(e => e.TRANS_GROUP_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("M_Master.Master_Code [MasterInfoType=GTTP]");
            entity.Property(e => e.TRANS_AMT)
                .HasComment("จำนวนเงินค่าใช้จ่าย")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TRANS_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.TRANS_CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.TRANS_DUP_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TRANS_EST_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TRANS_NAME_EN)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่ออังกฤษ");
            entity.Property(e => e.TRANS_NAME_TH)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อไทย");
            entity.Property(e => e.TRANS_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน");
            entity.Property(e => e.TRANS_TAX_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะ TAX");
            entity.Property(e => e.TRANS_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้แก้ไข");
            entity.Property(e => e.TRANS_UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
            entity.Property(e => e.TRANS_VAT_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะคิด Vat");
        });

        modelBuilder.Entity<M_TRANS_DETAIL>(entity =>
        {
            entity.HasKey(e => e.TRANSD_ID);

            entity.Property(e => e.TRANSD_EXPENSE_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TRANSD_FIELD)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TRANSD_FROM).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TRANSD_TO).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TRANSD_TRANS_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TRANSD_VALUE).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<M_USER>(entity =>
        {
            entity.HasKey(e => e.USER_LOGIN);

            entity.Property(e => e.USER_LOGIN)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("LoginUser จาก AD");
            entity.Property(e => e.USER_AD_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.USER_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.USER_CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.USER_FIRST_NAME)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อ");
            entity.Property(e => e.USER_LAST_NAME)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("นามสกุล");
            entity.Property(e => e.USER_PASSWORD)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.USER_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะข้อมูล");
            entity.Property(e => e.USER_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้แก้ไข");
            entity.Property(e => e.USER_UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<M_USER_ROLE>(entity =>
        {
            entity.HasKey(e => new { e.USERROLE_USER_LOGIN, e.USERROLE_ROLE_CODE });

            entity.Property(e => e.USERROLE_USER_LOGIN)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("M_User.User_Login");
            entity.Property(e => e.USERROLE_ROLE_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("M_Role.Role_Code");
            entity.Property(e => e.USERROLE_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.USERROLE_CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.USERROLE_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะข้อมูล");
            entity.Property(e => e.USERROLE_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้แก้ไข");
            entity.Property(e => e.USERROLE_UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<M_WRITEOFF_SUBTYPE>(entity =>
        {
            entity.HasKey(e => new { e.SUBTYPE_CODE, e.SUBTYPE_GROUPE_CODE });

            entity.Property(e => e.SUBTYPE_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัส Sub Type");
            entity.Property(e => e.SUBTYPE_GROUPE_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัส Writeoff Type [M_Master.Master_Code]");
            entity.Property(e => e.SUBTYPE_AUCTION_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะขายทอดตลาด");
            entity.Property(e => e.SUBTYPE_BLACKCODE)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะเลขคดีดำ");
            entity.Property(e => e.SUBTYPE_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.SUBTYPE_CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.SUBTYPE_NAME_EN)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อ Sub Type ภาษาอังกฤษ");
            entity.Property(e => e.SUBTYPE_NAME_TH)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ชื่อ Sub Type ภาษาไทย");
            entity.Property(e => e.SUBTYPE_OS_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะ Outstanding Balance [0: ไม่มี, 1:มี]");
            entity.Property(e => e.SUBTYPE_OS_MAX)
                .HasComment("Outstanding Balance มากสุด")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SUBTYPE_OS_MIN)
                .HasComment("Outstanding Balance น้อยสุด")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SUBTYPE_OVD_DAY).HasComment("จำนวนวันที่ค้างชำระ");
            entity.Property(e => e.SUBTYPE_OVD_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะวันค้างชำระ");
            entity.Property(e => e.SUBTYPE_R3_DAY).HasComment("จำนวนวันที่ตอบรับจดหมาย R3");
            entity.Property(e => e.SUBTYPE_R3_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะการตอบรับจดหมาย R3 [0:ไม่ตอบรับ,1:ตอบรับ]");
            entity.Property(e => e.SUBTYPE_REDCODE)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะเลขคดีแดง");
            entity.Property(e => e.SUBTYPE_REPO_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะยึดรถ");
            entity.Property(e => e.SUBTYPE_REPO_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SUBTYPE_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน");
            entity.Property(e => e.SUBTYPE_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้ที่แก้ไข");
            entity.Property(e => e.SUBTYPE_UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
            entity.Property(e => e.SUBTYPE_WO_CAIMTAX)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะ Writeoff Caim Tax [0:ไม่มี 1:มี]");
            entity.Property(e => e.SUBTYPE_WO_CAIMTAX_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะ Writeoff Caim Tax Y:เคย N:ไม่เคย");
            entity.Property(e => e.SUBTYPE_WO_COMP)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะ Writeoff Company [0:ไม่มี 1:มี]");
            entity.Property(e => e.SUBTYPE_WO_COMP_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะ Writeoff Company Y:เคย N:ไม่เคย");
        });

        modelBuilder.Entity<S_CONTRACT>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ACTUAL_PAYMENT).HasColumnType("numeric(18, 8)");
            entity.Property(e => e.ADDRESS_LINE1)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ADDRESS_LINE2)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ADDRESS_LINE3)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ALL_INSURANCE_FINANCE).HasColumnType("numeric(18, 8)");
            entity.Property(e => e.ARREARS_AMOUNT).HasColumnType("numeric(20, 2)");
            entity.Property(e => e.ASSET_PRICE).HasColumnType("numeric(18, 8)");
            entity.Property(e => e.BALLOON_AMNT).HasColumnType("numeric(18, 8)");
            entity.Property(e => e.BODY)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BOR_BUSINESS_PHONE)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BOR_MOBILE_1)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BOR_MOBILE_2)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BOR_TELEPHONE)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BRAND)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BUCKET_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CHASSIS)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.COLLECTION_STATUS)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.COLOR_CD)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.COMP_BRANCH_CODE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.COMP_CODE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CONTRACT_CREATION_DATE).HasColumnType("datetime");
            entity.Property(e => e.CONTRACT_NO)
                .IsRequired()
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CONTRACT_STATUS)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CONTRACT_SUB_STATUS)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CONTRACT_TERM).HasColumnType("numeric(18, 8)");
            entity.Property(e => e.CONTRACT_TYPE)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CONT_CODE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CUSTOMER_TYPE)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CUST_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CUST_NAME_EN)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CUST_NAME_TH)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DATA_IMPORT_DATE).HasColumnType("datetime");
            entity.Property(e => e.DL_GROUPNAME)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.DL_NAME)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.DOWN_PAYMENT_AMNT).HasColumnType("numeric(18, 8)");
            entity.Property(e => e.FI_NAME)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FLEET_CUSTOMER_FLG)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.GUA1_BUSINESS_PHONE)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.GUA1_MOBILE_1)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.GUA1_MOBILE_2)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.GUA1_TELEPHONE)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.GUA2_BUSINESS_PHONE)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.GUA2_MOBILE_1)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.GUA2_MOBILE_2)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.GUA2_TELEPHONE)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.GUARANTOR_1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GUARANTOR_2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GUARANTOR_NAME_1)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.GUARANTOR_NAME_2)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ID_NUMBER)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LAST_PAYMENT_AMOUNT).HasColumnType("numeric(18, 8)");
            entity.Property(e => e.MODEL)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NEW_USED)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.OUTSTANDING_BALANCE).HasColumnType("numeric(18, 8)");
            entity.Property(e => e.OUTSTANDING_TERM).HasColumnType("numeric(18, 8)");
            entity.Property(e => e.OVERDUE_DATE).HasColumnType("datetime");
            entity.Property(e => e.OVERDUE_DAY).HasColumnType("numeric(18, 8)");
            entity.Property(e => e.OVERDUE_TERM).HasColumnType("numeric(18, 8)");
            entity.Property(e => e.PAID_AMT).HasColumnType("numeric(18, 8)");
            entity.Property(e => e.PAID_TERM).HasColumnType("numeric(18, 8)");
            entity.Property(e => e.PLATE_NO)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PLATE_PROVINCE)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PROVINCE_ID)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SALESMAN_NAME)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.SERVICE_BRAND)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SUB_PRODUCT)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TOTAL_FINANCE).HasColumnType("numeric(18, 8)");
            entity.Property(e => e.TOTAL_INTEREST_AMNT).HasColumnType("numeric(18, 8)");
        });

        modelBuilder.Entity<S_CONTRACT_CHEQUE>(entity =>
        {
            entity.HasKey(e => new { e.CONTRACT_NO, e.SR_NO });

            entity.Property(e => e.CONTRACT_NO)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("เลขที่สัญญา");
            entity.Property(e => e.SR_NO).HasComment("serial number");
            entity.Property(e => e.ACCOUNT_NO)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("เลขบัญชี");
            entity.Property(e => e.BANK_ID)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("รหัสธนาคาร");
            entity.Property(e => e.BRANCH_ID)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("รหัสสาขาธนาคาร");
            entity.Property(e => e.CHEQUE_CLEARING_CD)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("การเรียกเก็บเงินตามเช็ค ");
            entity.Property(e => e.CHEQUE_DEPOSIT_DATE)
                .HasComment("วันที่ฝากเช็ค")
                .HasColumnType("datetime");
            entity.Property(e => e.CHEQUE_NO)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("หมายเลขเช็ค");
            entity.Property(e => e.CHEQUE_SEQUENCE).HasComment("ลำดับเช็ค");
            entity.Property(e => e.CHEQUE_UPLOAD_DATE).HasColumnType("datetime");
            entity.Property(e => e.COMP_BRANCH_CODE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.COMP_CODE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DATA_IMPORT_DATE)
                .HasComment("วันที่นำข้อมูลเข้า")
                .HasColumnType("datetime");
            entity.Property(e => e.DUE_DATE)
                .HasComment("วันที่กำหนดชำระ")
                .HasColumnType("datetime");
            entity.Property(e => e.EMI_AMNT).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.RECORD_STATUS)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("สถานะบันทึก");
            entity.Property(e => e.REJECTION_STATUS)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("สถานะยกเลิก");
            entity.Property(e => e.STATUS_DATE)
                .HasComment("วันที่เปลี่ยนสถานะ")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<S_CONTRACT_COST>(entity =>
        {
            entity.HasKey(e => new { e.CONTRACT_NO, e.COST_SEQ_NO });

            entity.Property(e => e.CONTRACT_NO)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.COST_AMNT).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.COST_CLASSIFICATION_CD)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.COST_STATUS_CD)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.COST_TYPE_CD)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.COST_UPLOADED_DATE).HasColumnType("datetime");
            entity.Property(e => e.DATA_IMPORT_DATE).HasColumnType("datetime");
            entity.Property(e => e.DATE_CHARGED).HasColumnType("datetime");
            entity.Property(e => e.DD_DATE).HasColumnType("datetime");
            entity.Property(e => e.DELETED_BY)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OUTSTANDING_COST_AMNT).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.OUTSTANDING_VAT).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.RECORD_STATUS)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RECOVERY_DATE).HasColumnType("datetime");
            entity.Property(e => e.REMARKS)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.RETURN_REMARKS)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.THIRD_PARTY_NAME)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TRANSACTION_DATE).HasColumnType("datetime");
            entity.Property(e => e.VAT_PAID).HasColumnType("decimal(18, 8)");
        });

        modelBuilder.Entity<S_CONTRACT_CUST>(entity =>
        {
            entity.HasKey(e => new { e.CONTRACT_NO, e.CUST_CODE, e.CUST_BR_TYPE }).HasName("PK_S_CONTRACT_CUST_1");

            entity.Property(e => e.CONTRACT_NO)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CUST_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CUST_BR_TYPE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DATA_IMPORT_DATE).HasColumnType("datetime");
            entity.Property(e => e.SEND_SMS)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<S_CONTRACT_CUST_ADDRESS>(entity =>
        {
            entity.HasKey(e => new { e.CONTRACT_NO, e.CUST_CODE, e.NO_IN_CUST });

            entity.Property(e => e.CONTRACT_NO)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CUST_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ADDRESS_BUSINESS_ID)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ADDRESS_ID)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ADDRESS_LINE1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ADDRESS_LINE2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ADDRESS_LINE3)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ADDRESS_LINE4)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ADDR_TYPE)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CITY)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CUST_BR_TYPE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DATA_IMPORT_DATE).HasColumnType("datetime");
            entity.Property(e => e.DISTRICT)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.OFFICE_TYPE)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.POSTAL)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PROVINCE)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SUBURB)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<S_CONTRACT_DELINQUENCY>(entity =>
        {
            entity.HasKey(e => e.CONTRACT_NO);

            entity.Property(e => e.CONTRACT_NO)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ARREAR_AMOUNT).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.CREATE_DATE).HasColumnType("datetime");
            entity.Property(e => e.CREATE_USER)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.DATA_IMPORT_DATE).HasColumnType("datetime");
            entity.Property(e => e.DELINQUENCY_ON_HOLD_STATUS)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DELINQUENCY_REASON_CD)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DELINQUENT_SINCE).HasColumnType("datetime");
            entity.Property(e => e.OPRATOR_ASSGN_DATE).HasColumnType("datetime");
            entity.Property(e => e.OVERDUE_SINCE).HasColumnType("datetime");
            entity.Property(e => e.PENALTY_INTEREST_WAIVER_STATUS)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RECORD_STATUS)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.STAGE_OFFICER_CHANGED_CD)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TOTAL_DELINQUENT_AMNT).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.TOTAL_OVERDUE_AMOUNT).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.TRANSMIT_ON_HOLD_CD)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UPDATE_DATE).HasColumnType("datetime");
            entity.Property(e => e.UPDATE_USER)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.USER_ALLOCATED)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<S_CONTRACT_INTERACTION>(entity =>
        {
            entity.HasKey(e => new { e.CONTRACT_NO, e.INTERACTION_ID });

            entity.Property(e => e.CONTRACT_NO)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CREATE_DATE).HasColumnType("datetime");
            entity.Property(e => e.CREATE_USER)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DATA_IMPORT_DATE).HasColumnType("datetime");
            entity.Property(e => e.INTERACTION_NOTES)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.INTERACTION_SUB_TYPE)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.INTERACTION_TYPE)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<S_CONTRACT_OVERDUE>(entity =>
        {
            entity.HasKey(e => e.CONTRACT_NO);

            entity.Property(e => e.CONTRACT_NO)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DELINQUENT_SINCE).HasColumnType("datetime");
            entity.Property(e => e.OVERDUE_SINCE).HasColumnType("datetime");
            entity.Property(e => e.UPDATE_DATE).HasColumnType("datetime");
        });

        modelBuilder.Entity<S_CONTRACT_PMT_RECEIPT>(entity =>
        {
            entity.HasKey(e => new { e.CONTRACT_NO, e.NO_IN_CONTRACT }).HasName("PK_S_CONTRACT_PMT_RECEIPT_1");

            entity.Property(e => e.CONTRACT_NO)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AMOUNT_EXCL_VAT).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.APPLICABLE_WHT_RATE).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.CLASSIFICATION_CD)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DATA_IMPORT_DATE).HasColumnType("datetime");
            entity.Property(e => e.INVOICE_RECEIPT_DATE).HasColumnType("datetime");
            entity.Property(e => e.INVOICE_RECEIPT_NO)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PAIRED_INVOICE_NUMBER)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PAYMENT_CLASSIFICATION_CD)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PENALTY_CHARGE_AMNT).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.PROCESSING_DATE).HasColumnType("datetime");
            entity.Property(e => e.RECORD_STATUS)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.STATUS_CD)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.VAT_AMOUNT).HasColumnType("decimal(18, 8)");
        });

        modelBuilder.Entity<S_CONTRACT_PMT_SCHEDULE>(entity =>
        {
            entity.HasKey(e => new { e.CONTRACT_NO, e.PAYMENT_ID });

            entity.Property(e => e.CONTRACT_NO)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ACCRUED_OUTSTANDING_INTEREST_AMNT).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.ACTUAL_PAYMENT_DATE).HasColumnType("datetime");
            entity.Property(e => e.BONUS_AMNT).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.CALCULATED_PAYMENT_DATE).HasColumnType("datetime");
            entity.Property(e => e.DATA_IMPORT_DATE).HasColumnType("datetime");
            entity.Property(e => e.DELINQUENCY_STATUS)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.INTEREST_RATE).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.OUTSTANDING_FEE_AMNT).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.OUTSTANDING_PRINCIPAL_AMNT).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.OUTSTANDING_SERVICES_AMNT).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.OUTSTANDING_TAX_AMNT).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.PAYMENT_APPLICATION_STATUS)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RECORD_STATUS)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SCHEDULED_FEE_AMNT).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.SCHEDULED_INTEREST_AMNT).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.SCHEDULED_PAYMENT_DATE).HasColumnType("datetime");
            entity.Property(e => e.SCHEDULED_PRINCIPAL_AMNT).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.SCHEDULED_SERVICES_AMNT).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.SCHEDULED_TAX_AMNT).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.TOTAL_CUST_PAYMENT_AMNT).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.UNPAID_PRINCIPAL_BALANCE_AMNT).HasColumnType("decimal(18, 8)");
        });

        modelBuilder.Entity<S_CUSTOMER_DETAIL>(entity =>
        {
            entity.HasKey(e => e.CUSTOMER_CODE);

            entity.Property(e => e.CUSTOMER_CODE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ALIAS_NAME)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ALIAS_NAME_LCL)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BIRTHDAY_TYPE_CD)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BRANCH_CODE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BUSINESS_CAT_CD)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BUSINESS_DETAIL)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BUSINESS_TYPE_CD)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.COMMENTS)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.COMMUNICATION_METHOD_CD)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.COMPANY_NAME)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.COMPANY_NAME_LCL)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.COMPANY_TYPE_CD)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.COMP_CODE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CONTACT_NAME)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CREATE_DATE).HasColumnType("datetime");
            entity.Property(e => e.CUSTOMER_EMAIL)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CUSTOMER_SUBTYPE_CD)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CUSTOMER_TYPE)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.C_TYPE_CD)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DATE_OF_BIRTH).HasColumnType("datetime");
            entity.Property(e => e.EMPLOYER_NAME)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EMPLOYER_PHONE)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EMPLOY_STATUS_CD)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FIRST_NAME)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FIRST_NAME_LCL)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FIRST_NAME_SEARCH)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GENDER)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ID_NUMBER)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ID_NUMBER_SEARCH)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ID_TYPE_CD)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.INCORPORATION_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_TITLE)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LAST_NAME)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.LAST_NAME_LCL)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.MARITAL_STATUS_CD)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.METHOD_OF_COMMUNICATATION)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.NATIONALITY)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NOTES)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.OCCUPATION)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PASSPORT_ID)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PRESIDENT_FULL_NAME)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SEND_SMS)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.STATUS_CD)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TAX_ID)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TAX_NUMBER)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TITLE_DESC)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TITLE_DESC_LCL)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TITLE_TYPE_CD)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UPDATE_DATE).HasColumnType("datetime");
            entity.Property(e => e.VOTER_ID)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<S_RPS>(entity =>
        {
            entity.HasKey(e => e.RPS_CONTRACT_NO).HasName("PK_S_RPS_AUCTION");

            entity.Property(e => e.RPS_CONTRACT_NO)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("เลขที่สัญญา");
            entity.Property(e => e.RPS_AUCTION_DATE)
                .HasComment("วันที่ประมูล")
                .HasColumnType("datetime");
            entity.Property(e => e.RPS_AUCTION_HOUSE)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("สถานที่จอดรถ");
            entity.Property(e => e.RPS_AUCTION_PRICE_AMT)
                .HasComment("ราคาประมูล")
                .HasColumnType("decimal(18, 8)");
            entity.Property(e => e.RPS_AUCTION_PRICE_VAT)
                .HasComment("ราคาประมูลรวม vat")
                .HasColumnType("decimal(18, 8)");
            entity.Property(e => e.RPS_OA)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ทิมติดตามและยึดรถ");
            entity.Property(e => e.RPS_R3_DATE)
                .HasComment("วันที่ออกจดหมาย R3")
                .HasColumnType("datetime");
            entity.Property(e => e.RPS_REMARKETING_STATUS)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("สถานะการประมูล");
            entity.Property(e => e.RPS_REMENPTION_DATE)
                .HasComment("วันที่ซื้อคืน")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<T_ACT_LOG>(entity =>
        {
            entity.HasKey(e => e.AL_ID);

            entity.Property(e => e.AC_DATE).HasColumnType("datetime");
            entity.Property(e => e.AL_DESC)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.AL_PROG_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AL_USER_LOGIN)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<T_BANKRUPTCY_FRAUD_D>(entity =>
        {
            entity.HasKey(e => e.BFD_ID);

            entity.Property(e => e.BFD_ID).HasComment("ลำดับ");
            entity.Property(e => e.BFD_CANCEL_BANKRUPTCY_DATE)
                .HasComment("วันที่ยกเลิกการล้มละลาย")
                .HasColumnType("datetime");
            entity.Property(e => e.BFD_CANCEL_COMPROMISE_AFTER_DATE)
                .HasComment("วันที่ยกเลิกประนอมหนี้หลังล้มและพิพากษาให้ล้มละลาย")
                .HasColumnType("datetime");
            entity.Property(e => e.BFD_CANCEL_COMPROMISE_BAFORE_DATE)
                .HasComment("วันที่ยกเลิกประนอมหนี้ก่อนล้มและพิพากษาให้ล้มละลาย")
                .HasColumnType("datetime");
            entity.Property(e => e.BFD_CANCEL_RECEIVING_ORDER_DATE)
                .HasComment("วันที่ศาลมีคำสั่งเพิกถอนพิทักษ์ทรัพย์เด็ดขาด")
                .HasColumnType("datetime");
            entity.Property(e => e.BFD_CARD_NO)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("เลขบัตรประชาชน");
            entity.Property(e => e.BFD_COMPROMISE_AFTER_DATE)
                .HasComment("วันที่ประนอมหนี้หลังล้มละลาย")
                .HasColumnType("datetime");
            entity.Property(e => e.BFD_COMPROMISE_BEFORE_DATE)
                .HasComment("วันที่ประนอมหนี้ก่อนล้มละลาย")
                .HasColumnType("datetime");
            entity.Property(e => e.BFD_CONTRACT_NO)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("เลขที่สัญญา");
            entity.Property(e => e.BFD_COURTNAME)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("ชื่อศาล");
            entity.Property(e => e.BFD_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.BFD_CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.BFD_DEFENDANT_NAME)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("ชื่อจำเลย");
            entity.Property(e => e.BFD_DISCHANGED_BANKRUPTCY_DATE)
                .HasComment("วันที่ปลดจากการเป็นบุคคลล้มละลาย")
                .HasColumnType("datetime");
            entity.Property(e => e.BFD_DISMISSAL_DATE)
                .HasComment("วันที่ยกฟ้อง")
                .HasColumnType("datetime");
            entity.Property(e => e.BFD_DISPOSE_CASE_DATE)
                .HasComment("วันที่จำหน่ายคดี")
                .HasColumnType("datetime");
            entity.Property(e => e.BFD_FILING_DATE)
                .HasComment("วันที่ฟ้อง")
                .HasColumnType("datetime");
            entity.Property(e => e.BFD_FIRSTNAME)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("ชื่อ");
            entity.Property(e => e.BFD_HID)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("T_BANKRUPTCY_FRAUD_H.DOC_ID");
            entity.Property(e => e.BFD_LASTNAME)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("นามสกุล");
            entity.Property(e => e.BFD_ORDER_BANKRUPCTY_DATE)
                .HasComment("วันที่ศาลมีคำสั่งพิพากษาให้ล้มละลาย")
                .HasColumnType("datetime");
            entity.Property(e => e.BFD_PLAINTIFF_NAME)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("ชื่อโจทย์");
            entity.Property(e => e.BFD_RECEIVING_ORDER_DATE)
                .HasComment("วันที่ศาลมีคำสั่งพิทักษ์ทรัพย์เด็ดขาด")
                .HasColumnType("datetime");
            entity.Property(e => e.BFD_REDCODE)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขคดีแดง");
            entity.Property(e => e.BFD_REMARK)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasComment("หมายเหตุ");
            entity.Property(e => e.BFD_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะใช้งาน A=Active,I=Inactive");
            entity.Property(e => e.BFD_SUBMIT_AFTER_DUE_DATE)
                .HasComment("วันที่ครบกำหนดยื่นคำขอรับชำระหนี้หลังล้ม")
                .HasColumnType("datetime");
            entity.Property(e => e.BFD_SUBMIT_DUE_DATE)
                .HasComment("วันที่ครบกำหนดยื่นคำขอรับชำระหนี้")
                .HasColumnType("datetime");
            entity.Property(e => e.BFD_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้แก้ไข");
            entity.Property(e => e.BFD_UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<T_BANKRUPTCY_FRAUD_H>(entity =>
        {
            entity.HasKey(e => e.BF_DOC_ID);

            entity.Property(e => e.BF_DOC_ID)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัส Doc");
            entity.Property(e => e.BF_APPROVE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้อนุมัติ");
            entity.Property(e => e.BF_APPROVE_DATE)
                .HasComment("วีนที่อนุมัติ")
                .HasColumnType("datetime");
            entity.Property(e => e.BF_APPROVE_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะการอนุมัติ W=Pending, A=Approved, R=Rejected");
            entity.Property(e => e.BF_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.BF_CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.BF_DATE)
                .HasComment("วันที่ Import file")
                .HasColumnType("datetime");
            entity.Property(e => e.BF_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะใช้งาน A=Active,I=Inactive");
            entity.Property(e => e.BF_TYPE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("ประเภท B=Bankruptcy, F=Fraud");
            entity.Property(e => e.BF_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้แก้ไข");
            entity.Property(e => e.BF_UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<T_BATCH_LOG>(entity =>
        {
            entity.HasKey(e => e.BATCH_LOG_ID);

            entity.Property(e => e.BATCH_LOG_ID).HasComment("รหัส Batch Log");
            entity.Property(e => e.BATCH_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัส Batch");
            entity.Property(e => e.BATCH_DATE)
                .HasComment("วันที่ batch ทำงาน")
                .HasColumnType("datetime");
            entity.Property(e => e.BATCH_DESC)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasComment("คำอธิบาย Batch");
            entity.Property(e => e.BATCH_RESULT_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะของ batch");
            entity.Property(e => e.BATCH_STEP)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("Step Batch");
        });

        modelBuilder.Entity<T_CHEQUE_DETAIL>(entity =>
        {
            entity.HasKey(e => new { e.CHQ_JOB_ID, e.CHQ_CHEQUE_NO, e.CHQ_CONTRACT_NO }).HasName("PK_T_CHEQUE_DETAIL_1");

            entity.Property(e => e.CHQ_JOB_ID)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("[T_JOB_LEGAL.JOB_ID]");
            entity.Property(e => e.CHQ_CHEQUE_NO)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("หมายเลขเช็ค");
            entity.Property(e => e.CHQ_CONTRACT_NO)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CHQ_ACCOUNT_NO)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("เลขที่บัญชี");
            entity.Property(e => e.CHQ_BANK_ID)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัสธนาคาร");
            entity.Property(e => e.CHQ_BANK_NAME)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CHQ_BORROWER_NAME)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CHQ_BRANCH_CODE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CHQ_BRANCH_NAME)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("รหัสสาขา");
            entity.Property(e => e.CHQ_CHEQUE_CLEARING_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CHQ_COMP_CODE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CHQ_DEPOSIT_DATE).HasColumnType("datetime");
            entity.Property(e => e.CHQ_DUE_DATE)
                .HasComment("วันที่กำหนดจ่ายเงิน")
                .HasColumnType("datetime");
            entity.Property(e => e.CHQ_EMI_AMOUNT).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CHQ_SR_NO).HasComment("ลำดับ");
            entity.Property(e => e.CHQ_UPLOAD_DATE)
                .HasComment("วันที่อัพโหลด")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<T_CURRENT_LOGIN>(entity =>
        {
            entity.HasKey(e => e.CL_ID);

            entity.Property(e => e.CL_ID).HasComment("Identity");
            entity.Property(e => e.CL_BRANCH_CODE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CL_COMP_CODE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CL_IP_ADDRESS)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ไอพี");
            entity.Property(e => e.CL_LAST_ACT_DATE)
                .HasComment("วันที่เข้าใช้งานล่าสุด")
                .HasColumnType("datetime");
            entity.Property(e => e.CL_LOGIN_DATE)
                .HasComment("วันที่เข้าระบบ")
                .HasColumnType("datetime");
            entity.Property(e => e.CL_ROLE_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("M_Role.Role_Code");
            entity.Property(e => e.CL_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน");
            entity.Property(e => e.CL_USER_LOGIN)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("M_User.User_Login");
        });

        modelBuilder.Entity<T_DOCUMENT>(entity =>
        {
            entity.HasKey(e => new { e.TDOC_JOB_ID, e.TDOC_DOC_CODE });

            entity.Property(e => e.TDOC_JOB_ID)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัส Job");
            entity.Property(e => e.TDOC_DOC_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัสเอกสาร");
            entity.Property(e => e.TDOC_CONTRACT_NO)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("เลขที่สัญญา");
            entity.Property(e => e.TDOC_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.TDOC_CRREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.TDOC_FAIL_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะของเอกสารที่ Fail");
            entity.Property(e => e.TDOC_REASON_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัสเหตุผลเอกสาร");
            entity.Property(e => e.TDOC_REMARK)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("หมายเหตุ");
            entity.Property(e => e.TDOC_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะการใช้งาน A= Active,I=Inactive");
            entity.Property(e => e.TDOC_SUCC_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะของเอกสารที่ Success");
            entity.Property(e => e.TDOC_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้แก้ไข");
            entity.Property(e => e.TDOC_UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<T_EXPENSE_D>(entity =>
        {
            entity.HasKey(e => e.EXPENSED_ID);

            entity.Property(e => e.EXPENSED_ID).HasComment("running number");
            entity.Property(e => e.EXPENSED_AMOUNT_CLAIMED).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.EXPENSED_AMT)
                .HasComment("จำนวนเงินค่าใช้จ่าย")
                .HasColumnType("decimal(18, 8)");
            entity.Property(e => e.EXPENSED_CONTRACT_NO)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("เลขที่สัญญา");
            entity.Property(e => e.EXPENSED_COURT_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("M_COURT.COURT_CODE รหัสศาล");
            entity.Property(e => e.EXPENSED_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.EXPENSED_CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.EXPENSED_FILING_DATE)
                .HasComment("วันที่ยื่นฟ้อง")
                .HasColumnType("datetime");
            entity.Property(e => e.EXPENSED_HID)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("EXPENSE_H.EXPENSE_ID");
            entity.Property(e => e.EXPENSED_JOB_ID)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัส Job ID");
            entity.Property(e => e.EXPENSED_PAYMENT_REF)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("อ้างอิง Payment No. เมื่อรับค่าธรรมเนียมศาลคืน");
            entity.Property(e => e.EXPENSED_RECEIVE_BANK_CODE)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("รหัสธนาคาร [M_MASTER.MASTER_CODE  MASTER_TYPE='BANK']");
            entity.Property(e => e.EXPENSED_RECEIVE_CHEQUE_DATE).HasColumnType("datetime");
            entity.Property(e => e.EXPENSED_RECEIVE_CHEQUE_NO)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("หมายเลขเช็คที่รับเงินคืน");
            entity.Property(e => e.EXPENSED_RECEIVE_TYPE)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasComment("ประเภทการรับคืน [C=Cheque, T=Transfer]");
            entity.Property(e => e.EXPENSED_RECVIVE_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะรับเงินคืน [0=จ่ายเงิน,1=รับเงินคืน]");
            entity.Property(e => e.EXPENSED_REMARK)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("หมายเหตุ");
            entity.Property(e => e.EXPENSED_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะการใช้งาน A= Active,I=Inactive");
            entity.Property(e => e.EXPENSED_TAX).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.EXPENSED_TOTAL)
                .HasComment("จำนวนเงินรวม")
                .HasColumnType("decimal(18, 8)");
            entity.Property(e => e.EXPENSED_TRANS_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัส Expense [M_TRANSACTION.TRANS_CODE]");
            entity.Property(e => e.EXPENSED_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้แก้ไข");
            entity.Property(e => e.EXPENSED_UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
            entity.Property(e => e.EXPENSED_VAT)
                .HasComment("จำนวน VAT")
                .HasColumnType("decimal(18, 8)");
        });

        modelBuilder.Entity<T_EXPENSE_H>(entity =>
        {
            entity.HasKey(e => e.EXPENSE_ID).HasName("PK_T_EXPENSE");

            entity.Property(e => e.EXPENSE_ID)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัส Expense ");
            entity.Property(e => e.EXPENSE_APPROVE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้อนุมัติ");
            entity.Property(e => e.EXPENSE_APPROVE_DATE)
                .HasComment("วันที่อนุมัติ")
                .HasColumnType("datetime");
            entity.Property(e => e.EXPENSE_APPROVE_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะการอนุมัติ");
            entity.Property(e => e.EXPENSE_BENEFICIARY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้รับเงิน");
            entity.Property(e => e.EXPENSE_BENEFICIARY_TYPE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("ประเภทผู้รับเงิน");
            entity.Property(e => e.EXPENSE_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.EXPENSE_CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.EXPENSE_DATE)
                .HasComment("วันที่จ่ายเงิน")
                .HasColumnType("datetime");
            entity.Property(e => e.EXPENSE_INVOICE_NO)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EXPENSE_REMARK)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("หมายเหตุ");
            entity.Property(e => e.EXPENSE_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะการใช้งาน A= Active,I=Inactive");
            entity.Property(e => e.EXPENSE_TYPE)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("ประเภทค่าใช้จ่าย C=Court Fee,O=Other Expense");
            entity.Property(e => e.EXPENSE_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้แก้ไข");
            entity.Property(e => e.EXPENSE_UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<T_JOB_ALL>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("T_JOB_ALL");

            entity.Property(e => e.JOB_ADMIN_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_ADMIN_NAME)
                .HasMaxLength(201)
                .IsUnicode(false);
            entity.Property(e => e.JOB_AMOUNT_CLAIMED).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_ASSIGN_ADMIN_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_ASSIGN_OA_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_BRAND)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CASE_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CASE_COLOR)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CASE_NAME)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CASE_STATUS_COLOR)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CHEQUE_LIST)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CONTRACT_LIST)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CONTRACT_NO)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CONTRACT_TYPE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CUST_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CUST_NAME)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.JOB_DOC_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JOB_FILING_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_ID)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_LEGAL_STATUS)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_LEGAL_STATUS_NAME)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.JOB_MODEL)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.JOB_OA_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_OA_NAME)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.JOB_OS_AMT_COL).HasColumnType("numeric(18, 8)");
            entity.Property(e => e.JOB_OVD_DAY_COL).HasColumnType("numeric(18, 8)");
            entity.Property(e => e.JOB_PLATE_NO)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.JOB_REPO_STATUS)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_REPO_STATUS_NAME)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.JOB_SHORT_FALL).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JOB_STEP_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_TYPE)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<T_JOB_LEGAL>(entity =>
        {
            entity.HasKey(e => e.JOB_ID).HasName("PK_T_JOB_LEGAL_2");

            entity.Property(e => e.JOB_ID)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัส JOB");
            entity.Property(e => e.JOB_ADMIN_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัส Admin");
            entity.Property(e => e.JOB_AML_ORDER_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_AML_ORDER_NO)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.JOB_AMOUNT_CLAIMED)
                .HasComment("จำนวนเงินที่เรียกร้อง")
                .HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_ANNOUNCE_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_APPOINTED_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_APPOINTMENT_CHECK_DATE)
                .HasComment("วันนัดตรวจคำขอรับชำระหนี้")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_APPOINT_DATE)
                .HasComment("วันนัดหมาย")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_ASSET_DESC)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("รายละเอียดสินทรัพย์");
            entity.Property(e => e.JOB_ASSIGNED_DATE)
                .HasComment("Assigned Date")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_ASSIGN_ADMIN_DATE)
                .HasComment("วันที่แจกงานให้ Admin")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_ASSIGN_OA_DATE)
                .HasComment("วันที่แจกงานให้ OA")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_ASSIGN_REMARK)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("หมายเหตุแจกงาน");
            entity.Property(e => e.JOB_ASSURED_AMOUNT)
                .HasComment("จำนวนเงินประกัน")
                .HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_ATTORNEY_DATE)
                .HasComment("Attorney Date")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_ATTORNEY_STATUS)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("Attorney Status");
            entity.Property(e => e.JOB_BANKRUPTCY_DATE)
                .HasComment("Bankruptcy Date")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_BANKRUPTCY_DISCHARGED_DATE)
                .HasComment("Discharged from Bankruptcy Date")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_BASE_COUNT).HasComment("ฐาน");
            entity.Property(e => e.JOB_BLACK_CODE)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("เลขคดีดำ");
            entity.Property(e => e.JOB_BRAND)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ยี่ห้อรถ");
            entity.Property(e => e.JOB_CARD_NO)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("เลขบัตรประชาชน");
            entity.Property(e => e.JOB_CAR_RECEIVE_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_CAR_RECEIVE_PLACE)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("สถานที่รับรถ");
            entity.Property(e => e.JOB_CASE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("M_LEGAL_CASE.CASE_CODE");
            entity.Property(e => e.JOB_CASE_OTHER)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CASE_TYPE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CASH_RECEIVE_DATE)
                .HasComment("วันที่รับเงิน")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_CHEQUE_LIST)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CHEQUE_NO)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Cheque No.");
            entity.Property(e => e.JOB_COMPANY_PLAN)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CONTRACT_LIST)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CONTRACT_NO)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("S_CONTRACT_DETAIL.CONTRACT_NO");
            entity.Property(e => e.JOB_CONTRACT_TERMINATED_DATE)
                .HasComment("Contract Terminated Date")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_COURT_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("ศาล");
            entity.Property(e => e.JOB_COURT_FEE)
                .HasComment("ค่าธรรมเนียมศาล")
                .HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.JOB_CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_CUST_ADDRESS)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CUST_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัสลูกค้า");
            entity.Property(e => e.JOB_CUST_NAME)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อ-นามสกุลลูกค้า");
            entity.Property(e => e.JOB_CUST_TYPE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("ประเภทลูกค้า");
            entity.Property(e => e.JOB_DEBTOR_STATUS)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("Debtor Status");
            entity.Property(e => e.JOB_DETAILS)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasComment("รายละเอียด");
            entity.Property(e => e.JOB_DOC_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะเอกสาร");
            entity.Property(e => e.JOB_DUE_DATE)
                .HasComment("กำหนดชำระ")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_DUE_DAY).HasComment("ชำระทุกวันที่");
            entity.Property(e => e.JOB_ENFORCEMENT_DATE)
                .HasComment("วันที่บังคับฟ้อง")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_ENFORCEMENT_EFF_DATE)
                .HasComment("วันที่ตั้งเรื่องบังคับคดี")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_EXECUTION_DATE)
                .HasComment("วันที่บังคับคดี")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_EXECUTION_END_DATE)
                .HasComment("วันสิ้นสุดบังคับคดี")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_EXPIRE_DATE)
                .HasComment("วันหมดอายุ")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_FILING_DATE)
                .HasComment("วันที่ยื่นเรื่องฟ้องศาล")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_INST_AMT)
                .HasComment("ค่างวดต่องวด")
                .HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_INST_PAID)
                .HasComment("ค่างวดที่จ่ายไปแล้ว")
                .HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_INSURER_NAME)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.JOB_JUDGMENT_DATE)
                .HasComment("วันที่ศาลพิพากษา")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_LACK_OF_BENEFIT)
                .HasComment("Opportunity Cost")
                .HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_LAST_DUE_DATE)
                .HasComment("วันสุดท้ายที่จ่ายเงิน")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_LAWYER_FEE)
                .HasComment("Lawyer Fee")
                .HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_LEGAL_STATUS)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("สถานะ Legal");
            entity.Property(e => e.JOB_MAILING_DATE)
                .HasComment("วันที่ส่งจดหมาย R3")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_MODEL)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("รุ่นรถ");
            entity.Property(e => e.JOB_NOTICE_DATE)
                .HasComment("วันทีนำส่งหมายศาล")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_NOTIFY_CHEQUE_DATE)
                .HasComment("Notify Cheque Date")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_OA_ASSET_SEARCH)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("OA สืบทรัพย์");
            entity.Property(e => e.JOB_OA_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัส OA");
            entity.Property(e => e.JOB_OA_ENFORCEMENT)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("OA บังคับคดี");
            entity.Property(e => e.JOB_ORDERED_REH)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.JOB_OS_AMT)
                .HasComment("จำนวนเงินคงเหลือ")
                .HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_OVD_AMT)
                .HasComment("จำนวนเงินค้างชำระ")
                .HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_OVD_DAY).HasComment("จำนวนวันที่ค้างชำระ");
            entity.Property(e => e.JOB_OVD_TERM)
                .HasComment("จำนวนงวดค้างชำระ")
                .HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_PAID_TERM)
                .HasComment("จำนวนงวดที่จ่ายไปแล้ว")
                .HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_PARTY_IN_LAW_SUIT)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.JOB_PLAINTIFF_NAME)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อโจทย์");
            entity.Property(e => e.JOB_PLATE_NO)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("เลขทะเบียนรถ");
            entity.Property(e => e.JOB_POLICE_STATION)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("Police Station");
            entity.Property(e => e.JOB_POL_NO)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("POL No");
            entity.Property(e => e.JOB_R3_ID)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_REALLOCATE_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะตกชั้น");
            entity.Property(e => e.JOB_RECEIVE_ORDER_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_RED_CODE)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("เลขคดีแดง");
            entity.Property(e => e.JOB_REMARK)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("หมายเหตุ");
            entity.Property(e => e.JOB_REPORT_DATE)
                .HasComment("วันที่ส่งรายงานสืบทรัพย์")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_REPO_STATUS)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("สถานะการยึดรถ");
            entity.Property(e => e.JOB_REQUESTOR)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.JOB_REQUEST_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_SECOND_LAWYER_FEE)
                .HasComment("Second Lawyer Fee")
                .HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_SEIZE_DATE)
                .HasComment("วันที่นำยึด")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_SHORT_FALL)
                .HasComment("ส่วนขาดทุน")
                .HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะการใช้งาน A= Active,I=Inactive");
            entity.Property(e => e.JOB_STEP_DATE)
                .HasComment("วันที่เปลี่ยนสถานะ")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_STOLEN_NO)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("หมายเลขตั้งบังคับคดี");
            entity.Property(e => e.JOB_SUBMISSION_AMOUNT)
                .HasComment("Payment Submission Amount")
                .HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_SUBMISSION_DATE)
                .HasComment("Submission Date")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_SUBMIT_ENFORCEMENT_DATE)
                .HasComment("วันทีส่งไปบังคับคดี")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_SUBMIT_INVEST_DATE)
                .HasComment("วันที่ส่งไปสืบทรัพย์")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_TOTAL_LOSS_AMOUNT)
                .HasComment("ค่าเสียหายโดนสิ้นเชิง")
                .HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้แก้ไข");
            entity.Property(e => e.JOB_UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_WITHDRAW_DATE)
                .HasComment("วันที่ถอนฟ้อง")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_WITNESS_DATE)
                .HasComment("Witness Date")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_WITNESS_TIME)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("Witness Time");
        });

        modelBuilder.Entity<T_JOB_R3>(entity =>
        {
            entity.HasKey(e => e.JOB_ID);

            entity.Property(e => e.JOB_ID)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัส job");
            entity.Property(e => e.JOB_ADMIN_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัส Admin");
            entity.Property(e => e.JOB_ASSET_DESC)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("รายละเอียดสินทรัพย์");
            entity.Property(e => e.JOB_ASSIGN_ADMIN_DATE)
                .HasComment("วันที่จ่ายงานให้ Admin")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_ASSIGN_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้จ่ายงาน");
            entity.Property(e => e.JOB_ASSIGN_OA_DATE)
                .HasComment("วันที่จ่ายงานให้ OA")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_ASSIGN_REMARK)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("หมายเหตุการจ่ายงาน");
            entity.Property(e => e.JOB_BASE_COUNT).HasComment("ฐาน");
            entity.Property(e => e.JOB_BRACH_CODE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JOB_BRAND)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ยี่ห้อรถ");
            entity.Property(e => e.JOB_BUCKET)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("ระดับการติดตามหนี้ ");
            entity.Property(e => e.JOB_CARD_NO)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("เลขที่บัตรแสดงตน (บัตรประชาชน หรือ เลขที่นิติบุคคล)");
            entity.Property(e => e.JOB_COMP_CODE)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JOB_CONTRACT_NO)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("เลขที่สัญญา");
            entity.Property(e => e.JOB_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.JOB_CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_CUST_BR_TYPE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("ประเภทลูกค้าใน Contract (Borrower, Guarantor)");
            entity.Property(e => e.JOB_CUST_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัสลูกค้า");
            entity.Property(e => e.JOB_CUST_CR_TYPE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("ประเภทของลูกค้า (Person, Corporate)");
            entity.Property(e => e.JOB_CUST_NAME)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อ-นามสกุลลูกค้า");
            entity.Property(e => e.JOB_EXPIRE_DATE)
                .HasComment("วันหมดอายุ")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_GEN_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JOB_MODEL)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("รุ่นรถ");
            entity.Property(e => e.JOB_OA_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัส OA");
            entity.Property(e => e.JOB_OS_AMT)
                .HasComment("จำนวนเงินคงเหลือ")
                .HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_OVD_AMT)
                .HasComment("จำนวนเงินค้างชำระ")
                .HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_OVD_DAY).HasComment("จำนวนวันที่ค้างชำระ");
            entity.Property(e => e.JOB_OVD_TERM)
                .HasComment("จำนวนงวดค้างชำระ")
                .HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JOB_PLATE_NO)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("เลขทะเบียนรถ");
            entity.Property(e => e.JOB_R3_RECEVIE_DATE)
                .HasComment("วันที่ลูกค้าตอบรับจดหมาย R3 ล่าสุด")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_R3_SEND_DATE)
                .HasComment("วันที่ส่งจดหมาย R3")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_R3_STATUS)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("สถานะของจดหมาย 10 = กำลังรอส่ง 20 = รอการบันทึกการส่งจดหมาย  30 ดำเนินการสำเร็จ");
            entity.Property(e => e.JOB_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะการใช้งาน A= Active,I=Inactive");
            entity.Property(e => e.JOB_STEP_DATE)
                .HasComment("วันที่เปลี่ยนสถานะ")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้แก้ไข");
            entity.Property(e => e.JOB_UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<T_JOB_REPO>(entity =>
        {
            entity.HasKey(e => e.JOB_ID);

            entity.Property(e => e.JOB_ID)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัส Job");
            entity.Property(e => e.JOB_ADMIN_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัส Admin");
            entity.Property(e => e.JOB_ASSET_DESC)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("รายละเอียดสินทรัพย์");
            entity.Property(e => e.JOB_ASSIGN_ADMIN_DATE)
                .HasComment("วันที่จ่ายงานให้ Admin")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_ASSIGN_OA_DATE)
                .HasComment("วันที่จ่ายงานให้ OA")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_ASSIGN_REMARK)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("หมายเหตุการจ่ายงาน");
            entity.Property(e => e.JOB_BASE_COUNT).HasComment("ฐาน");
            entity.Property(e => e.JOB_BRAND)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ยี่ห้อรถ");
            entity.Property(e => e.JOB_BUCKET)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("ระดับการติดตามหนี้ ");
            entity.Property(e => e.JOB_CARD_NO)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("เลขบัตรประชน");
            entity.Property(e => e.JOB_CAR_PARK)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("สถานที่จอดรถ");
            entity.Property(e => e.JOB_CASE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("M_LEGAL_CASE.CASE_CODE");
            entity.Property(e => e.JOB_CHARGE_DATE)
                .HasComment("วันที่เริ่มคำนวณค่าขาดประโยชน์")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_CONTRACT_NO)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("เลขที่สัญญา");
            entity.Property(e => e.JOB_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.JOB_CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_CUST_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัสผู้เช่าซื้อ");
            entity.Property(e => e.JOB_CUST_NAME)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อ-นามสกุลผู้เช่าซื้อ");
            entity.Property(e => e.JOB_CUST_TYPE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("ประเภทผู้เช่าซื้อ");
            entity.Property(e => e.JOB_DOC_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะเอกสาร");
            entity.Property(e => e.JOB_DUE_DATE)
                .HasComment("กำหนดชำระ")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_DUE_DAY).HasComment("ชำระทุกวันที่");
            entity.Property(e => e.JOB_EXPIRE_DATE)
                .HasComment("วันหมดอายุ")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_FEE_EXPENSE)
                .HasComment("ค่าธรรมเนียม")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.JOB_GEN_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JOB_INST_AMT)
                .HasComment("ค่างวดต่องวด")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.JOB_INST_PAID)
                .HasComment("ค่างวดที่จ่ายไปแล้ว")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.JOB_LEGAL_STATUS)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("สถานะทางกฎหมาย");
            entity.Property(e => e.JOB_MILEAGE)
                .HasComment("เลขไมล์")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.JOB_MODEL)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("รุ่นรถ");
            entity.Property(e => e.JOB_NOTI_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะการแจ้งเตือน");
            entity.Property(e => e.JOB_OA_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัส OA");
            entity.Property(e => e.JOB_OA_SUCCESS)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัส OA ที่ยึดรถสำเร็จ");
            entity.Property(e => e.JOB_OS_AMT)
                .HasComment("จำนวนเงินคงเหลือ")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.JOB_OTHER_EXPENSE)
                .HasComment("ค่าใช้จ่ายอื่นๆ")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.JOB_OVD_AMT)
                .HasComment("จำนวนเงินค้างชำระ")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.JOB_OVD_DAY).HasComment("จำนวนวันที่ค้างชำระ");
            entity.Property(e => e.JOB_OVD_TERM)
                .HasComment("จำนวนงวดค้างชำระ")
                .HasColumnType("decimal(18, 6)");
            entity.Property(e => e.JOB_PAID_TERM)
                .HasComment("จำนวนงวดที่จ่ายไปแล้ว")
                .HasColumnType("decimal(18, 6)");
            entity.Property(e => e.JOB_PLATE_NO)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("เลขทะเบียนรถ");
            entity.Property(e => e.JOB_PROVINCE_CODE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_PROVINCE_REPO)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_R3_ID)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JOB_R3_RECEVIE_DATE)
                .HasComment("วันที่ตอบรับจดหมาย R3")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_R3_SEND_DATE)
                .HasComment("วันที่ส่งจดหมาย R3")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_REALLOCATE_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะตกชั้น");
            entity.Property(e => e.JOB_RECEIVE_REMARK)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("หมายเหตุการรับรถ");
            entity.Property(e => e.JOB_REPO_DATE)
                .HasComment("วันที่ยึดรถ")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_REPO_EXPENSE)
                .HasComment("ค่าใช้จ่ายในการติดตามรถ")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.JOB_REPO_STATUS)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("สถานะการติดตามรถ");
            entity.Property(e => e.JOB_REPO_TYPE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("ประเภท การติดตามและยึดรถ");
            entity.Property(e => e.JOB_RPS_DATE).HasColumnType("datetime");
            entity.Property(e => e.JOB_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะการติดตามและยึดรถ");
            entity.Property(e => e.JOB_STEP_DATE)
                .HasComment("วันที่เปลี่ยนสถานะ")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_TRANS_DATE)
                .HasComment("วันที่ทำรายการ")
                .HasColumnType("datetime");
            entity.Property(e => e.JOB_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้แก้ไข");
            entity.Property(e => e.JOB_UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<T_JUDGMENTDEBTOR_ATTACHMENT>(entity =>
        {
            entity.HasKey(e => new { e.JDA_HID, e.JDA_JOB_ID, e.JDA_SEQUENCE });

            entity.Property(e => e.JDA_HID)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JDA_JOB_ID)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JDA_SEQUENCE).ValueGeneratedOnAdd();
            entity.Property(e => e.JDA_CREATE_BY)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JDA_CREATE_DATE).HasColumnType("datetime");
            entity.Property(e => e.JDA_DESCRIPTION)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.JDA_FILE_NAME)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.JDA_FILE_PATH)
                .HasMaxLength(2500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<T_JUDGMENTDEBTOR_D>(entity =>
        {
            entity.HasKey(e => e.JDD_ID);

            entity.Property(e => e.JDD_ID).HasComment("รหัส T_JUDGMENTDEBTOR_D");
            entity.Property(e => e.JDD_AMOUNT)
                .HasComment("จำนวนเงินที่ตั้งไว้ ")
                .HasColumnType("decimal(18, 6)");
            entity.Property(e => e.JDD_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.JDD_CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.JDD_CREDITBUREAU_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะการส่งให้เครดิตรบูโร");
            entity.Property(e => e.JDD_GENERATE_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะการคำนวณตารางการชำระแบบแบ่งจ่าย");
            entity.Property(e => e.JDD_HID)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("[T_JUDGMENTDEBTOR_H.JD_ID]");
            entity.Property(e => e.JDD_INTEREST_DAYS).HasComment("จำนวนวันที่คิดดอกเบื้ย");
            entity.Property(e => e.JDD_INTEREST_END_DATE)
                .HasComment("วันที่สิ้นสุดคำนวณดอกเบี้ย")
                .HasColumnType("datetime");
            entity.Property(e => e.JDD_INTEREST_END_DATE_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะวันสิ้นสุดการคิดดอกเบี้ย");
            entity.Property(e => e.JDD_INTEREST_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะการคิดดอกเบี้ย");
            entity.Property(e => e.JDD_INTEREST_MONTHS).HasComment("จำนวนเดือนที่คิดดอกเบื้ย");
            entity.Property(e => e.JDD_INTEREST_RATE)
                .HasComment("อัตราดอกเบี้ย")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.JDD_INTEREST_START_DATE)
                .HasComment("วันที่เริ่มต้นคำนวณดอกเบี้ย")
                .HasColumnType("datetime");
            entity.Property(e => e.JDD_INTEREST_TYPE)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("ประเภทการคำนวณดอกเบื้ย");
            entity.Property(e => e.JDD_MONTHS_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JDD_PAYMENT_AMOUNT)
                .HasComment("เงินที่เรียกเก็บได้จริง")
                .HasColumnType("decimal(18, 6)");
            entity.Property(e => e.JDD_REMARK)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasComment("หมายเหตุ");
            entity.Property(e => e.JDD_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะการใช้งาน A= Active,I=Inactive");
            entity.Property(e => e.JDD_SUM_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะการคำนวณหนี้ตามคำพิพากษา");
            entity.Property(e => e.JDD_TRANS_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("M_TRANSACTION.TRANS_CODE");
            entity.Property(e => e.JDD_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้แก้ไข");
            entity.Property(e => e.JDD_UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<T_JUDGMENTDEBTOR_H>(entity =>
        {
            entity.HasKey(e => e.JD_ID);

            entity.Property(e => e.JD_ID)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัส JUDGMENTDEBTOR_H");
            entity.Property(e => e.JD_APPROVE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้อนุมัติ");
            entity.Property(e => e.JD_APPROVE_DATE)
                .HasComment("วันที่อนุมัติ")
                .HasColumnType("datetime");
            entity.Property(e => e.JD_APPROVE_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะการอนุมัติ");
            entity.Property(e => e.JD_APPROVE_REMARK)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.JD_CHEQUE_LIST)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.JD_COMPROMISE_DATE)
                .HasComment("วันที่ประนีประนอม")
                .HasColumnType("datetime");
            entity.Property(e => e.JD_CONTRACT_LIST)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.JD_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.JD_CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.JD_DEBTOR_STATUS)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("สถานะลูกหนี้");
            entity.Property(e => e.JD_FIRST_DUE_DATE)
                .HasComment("วันแรกที่ต้องจ่าย")
                .HasColumnType("datetime");
            entity.Property(e => e.JD_FURTHER_COMMENT)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasComment("รายละเอียด");
            entity.Property(e => e.JD_JOB_ID)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("[T_JOB_LEGAL.JOB_ID]");
            entity.Property(e => e.JD_JUDGMENT_DATE)
                .HasComment("วันที่ประนีประนอม")
                .HasColumnType("datetime");
            entity.Property(e => e.JD_PAY_DAY).HasComment("จ่ายทุกวันที่");
            entity.Property(e => e.JD_REMARK)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasComment("หมายเหตุ");
            entity.Property(e => e.JD_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะใช้งาน A=Active,I=Inactive");
            entity.Property(e => e.JD_TERM).HasComment("จำนวนงวดที่แบ่งจ่าย");
            entity.Property(e => e.JD_TOTAL).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JD_TYPE)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ประเภทการฟ้อง [Contract, Cheque]");
            entity.Property(e => e.JD_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้แก้ไข");
            entity.Property(e => e.JD_UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<T_JUDGMENTDEBTOR_PAYMENT>(entity =>
        {
            entity.HasKey(e => new { e.JDP_HID, e.JDP_TERM });

            entity.Property(e => e.JDP_HID)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.JDP_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JDP_CREATE_DATE).HasColumnType("datetime");
            entity.Property(e => e.JDP_DESCRIPTION)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.JDP_DUEDATE).HasColumnType("datetime");
            entity.Property(e => e.JDP_INSTALLMENT).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.JDP_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.JDP_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JDP_UPDATE_DATE).HasColumnType("datetime");
        });

        modelBuilder.Entity<T_LEGAL_ATTACHMENT>(entity =>
        {
            entity.HasKey(e => new { e.ATTACH_JOB_ID, e.ATTACH_SEQUENCE });

            entity.Property(e => e.ATTACH_JOB_ID)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ATTACH_BY)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ATTACH_DATE).HasColumnType("datetime");
            entity.Property(e => e.ATTACH_DESCRIPTION)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ATTACH_FILE_NAME)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<T_LEGAL_TRACKING>(entity =>
        {
            entity.HasKey(e => new { e.LEGAL_JOB_ID, e.LEGAL_SEQ_NO });

            entity.Property(e => e.LEGAL_JOB_ID)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัส job");
            entity.Property(e => e.LEGAL_SEQ_NO).HasComment("ลำดับ");
            entity.Property(e => e.LEGAL_AMOUNT_CLAIMED)
                .HasComment("ทุนทรัพย์ฟ้อง")
                .HasColumnType("decimal(18, 8)");
            entity.Property(e => e.LEGAL_APPOINTED_DATE).HasColumnType("datetime");
            entity.Property(e => e.LEGAL_APPOINTMENT_CHECK_DATE).HasColumnType("datetime");
            entity.Property(e => e.LEGAL_ASSIGNED_DATE)
                .HasComment("วันที่ฝ่ายกฎหมายได้รับสัญญา")
                .HasColumnType("datetime");
            entity.Property(e => e.LEGAL_ATTORNEY_DATE)
                .HasComment("วันที่นัดไต่สวน")
                .HasColumnType("datetime");
            entity.Property(e => e.LEGAL_ATTORNEY_STATUS)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("สถานะการไต่สวน");
            entity.Property(e => e.LEGAL_BANKRUPTCY_DATE)
                .HasComment("วันที่ล้มละลาย")
                .HasColumnType("datetime");
            entity.Property(e => e.LEGAL_BANKRUPTCY_DISCHARGED_DATE)
                .HasComment("วันที่ปลดจากล้มละลาย")
                .HasColumnType("datetime");
            entity.Property(e => e.LEGAL_BLACK_CODE)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขคดีดำ");
            entity.Property(e => e.LEGAL_CAR_RECEIVED_PLACE)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("สถานที่รับรถ");
            entity.Property(e => e.LEGAL_CASE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("กรณีคดีทางกฎหมาย M_LEGAL_CASE.CASE_CODE");
            entity.Property(e => e.LEGAL_CASH_RECEIVE_DATE).HasColumnType("datetime");
            entity.Property(e => e.LEGAL_CHEQUE_NO)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("หมายเลขเช็ค");
            entity.Property(e => e.LEGAL_CONTRACT_NO)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("เลขที่สัญญา");
            entity.Property(e => e.LEGAL_CONTRACT_TERMINATED_DATE)
                .HasComment("วันที่เลิกสัญญา")
                .HasColumnType("datetime");
            entity.Property(e => e.LEGAL_COURT_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("M_COURT.COURT_CODE");
            entity.Property(e => e.LEGAL_COURT_FEE)
                .HasComment("ค่าธรรมเนียมศาล")
                .HasColumnType("decimal(18, 8)");
            entity.Property(e => e.LEGAL_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.LEGAL_CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.LEGAL_DEBTOR_STATUS)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("สถานะลูกหนี้");
            entity.Property(e => e.LEGAL_DETAILS)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasComment("รายละเอียด");
            entity.Property(e => e.LEGAL_ENFORCEMENT_DATE)
                .HasComment("วันที่บังคับฟ้อง")
                .HasColumnType("datetime");
            entity.Property(e => e.LEGAL_ENFORCEMENT_EFF_DATE).HasColumnType("datetime");
            entity.Property(e => e.LEGAL_EXECUTION_DATE).HasColumnType("datetime");
            entity.Property(e => e.LEGAL_EXECUTION_END_DATE).HasColumnType("datetime");
            entity.Property(e => e.LEGAL_FILING_DATE)
                .HasComment("วันที่ยื่นฟ้องร้อง")
                .HasColumnType("datetime");
            entity.Property(e => e.LEGAL_JUDGMENT_DATE).HasColumnType("datetime");
            entity.Property(e => e.LEGAL_LACK_OF_BENEFIT)
                .HasComment("ค่าขาดประโยชน์")
                .HasColumnType("decimal(18, 8)");
            entity.Property(e => e.LEGAL_LAWYER_FEE)
                .HasComment("ค่าทนายความ")
                .HasColumnType("decimal(18, 8)");
            entity.Property(e => e.LEGAL_MAILING_DATE)
                .HasComment("วันที่ส่งจดหมาย")
                .HasColumnType("datetime");
            entity.Property(e => e.LEGAL_NOTICE_DATE)
                .HasComment("วันที่ฟ้อง")
                .HasColumnType("datetime");
            entity.Property(e => e.LEGAL_NOTIFY_CHEQUE_DATE)
                .HasComment("วันที่ฟ้องคดีเช็ค")
                .HasColumnType("datetime");
            entity.Property(e => e.LEGAL_OA_ASSET_SEARCH)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LEGAL_OA_ENFORCEMENT)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LEGAL_PARTY_IN_LAW_SUIT)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LEGAL_POLICE_STATION)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("สถานีตำรวจ");
            entity.Property(e => e.LEGAL_POL_NO)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขอาญา");
            entity.Property(e => e.LEGAL_RED_CODE)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขคดีแดง");
            entity.Property(e => e.LEGAL_REPORT_DATE).HasColumnType("datetime");
            entity.Property(e => e.LEGAL_SECOND_LAWYER_FEE).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.LEGAL_SEIZE_DATE).HasColumnType("datetime");
            entity.Property(e => e.LEGAL_STATUS)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("สถานะคดีทางกฎหมาย");
            entity.Property(e => e.LEGAL_STOLEN_NO)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("หมายเลขตั้งบังคับคดี");
            entity.Property(e => e.LEGAL_SUBMISSION_AMOUNT).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.LEGAL_SUBMISSION_DATE).HasColumnType("datetime");
            entity.Property(e => e.LEGAL_SUBMIT_ENFORCEMENT_DATE).HasColumnType("datetime");
            entity.Property(e => e.LEGAL_SUBMIT_INVEST_DATE).HasColumnType("datetime");
            entity.Property(e => e.LEGAL_TRACKING_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้ติดตาม");
            entity.Property(e => e.LEGAL_TRACKING_DATE)
                .HasComment("วันที่ติดตาม")
                .HasColumnType("datetime");
            entity.Property(e => e.LEGAL_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้แก้ไข");
            entity.Property(e => e.LEGAL_UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
            entity.Property(e => e.LEGAL_WITHDRAW_DATE).HasColumnType("datetime");
            entity.Property(e => e.LEGAL_WITNESS_DATE)
                .HasComment("วันที่นัดสืบพยาน")
                .HasColumnType("datetime");
            entity.Property(e => e.LEGAL_WITNESS_TIME)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("เวลานัดสืบพยาน");
        });

        modelBuilder.Entity<T_LOGIN_HISTORY>(entity =>
        {
            entity.HasKey(e => e.CL_ID);

            entity.Property(e => e.CL_ID).HasComment("รหัส login");
            entity.Property(e => e.CL_IP_ADDRESS)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ip address");
            entity.Property(e => e.CL_LAST_ACT_DATE)
                .HasComment("ครั้งสุดท้ายที่ใช้งาน")
                .HasColumnType("datetime");
            entity.Property(e => e.CL_LOGIN_DATE)
                .HasComment("วันที่ Login")
                .HasColumnType("datetime");
            entity.Property(e => e.CL_ROLE_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัส Role");
            entity.Property(e => e.CL_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน");
            entity.Property(e => e.CL_USER_LOGIN)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("User Login");
        });

        modelBuilder.Entity<T_R3_DETAIL>(entity =>
        {
            entity.HasKey(e => new { e.R3_JOB_ID, e.R3_CUST_CODE, e.R3_ADDR_ID }).HasName("PK_T_R3_DETAIL_1");

            entity.Property(e => e.R3_JOB_ID)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("เลขที่งานของจดหมาย Running By System");
            entity.Property(e => e.R3_CUST_CODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัสลูกค้า");
            entity.Property(e => e.R3_ADDR_ID)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("ประเภทที่อยู่ M= Mailing  , R= Registered");
            entity.Property(e => e.R3_ADDR_FULL)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("ที่อยู่ของผู้รับจดหมาย");
            entity.Property(e => e.R3_BARCODE)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("หมายเลขบาร์โค้ด สำหรับสแกนเมื่อลูกค้าตอบจดหมาย R3");
            entity.Property(e => e.R3_CARD_NO)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("เลขที่บัตรประชาชน");
            entity.Property(e => e.R3_CASE_STATUS)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("สถานะของจดหมาย 10 = กำลังรอส่ง 20 = รอการบันทึกการส่งจดหมาย  30=ดำเนินการสำเร็จ");
            entity.Property(e => e.R3_CONTRACT_NO)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("เลขที่สัญญา");
            entity.Property(e => e.R3_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เพิ่มข้อมูลโดย");
            entity.Property(e => e.R3_CREATE_DATE)
                .HasComment("วันที่เพิ่มข้อมูล")
                .HasColumnType("datetime");
            entity.Property(e => e.R3_CUST_BR_TYPE)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("ประเภทผู้รับจดหมาย B= Borrower  , G= Guarantor");
            entity.Property(e => e.R3_CUST_NAME)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("ชื่อ-นามสกุลผู้เช่าซื้อ");
            entity.Property(e => e.R3_EMS_TRACKING)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("เลขทะเบียนการส่งจดหมาย");
            entity.Property(e => e.R3_EXPIRE_DATE)
                .HasComment("วันที่จดหมายหมดอายุ 30 วัน")
                .HasColumnType("datetime");
            entity.Property(e => e.R3_FLAG)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.R3_ISSUE_DATE)
                .HasComment("วันที่ Generate ออกจากระบบ หรือวันที่ส่งให้ Printing Provider")
                .HasColumnType("datetime");
            entity.Property(e => e.R3_RECEVIE_DATE)
                .HasComment("วันที่ลูกค้าตอบรับใบเหลือง")
                .HasColumnType("datetime");
            entity.Property(e => e.R3_REJECTED_DATE).HasColumnType("datetime");
            entity.Property(e => e.R3_REMARK)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("หมายเหตุ");
            entity.Property(e => e.R3_SEND_DATE)
                .HasComment("วันที่ Printing Provider ส่งจดหมายให้กับผู้เช่าซื้อ")
                .HasColumnType("datetime");
            entity.Property(e => e.R3_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะการใช้งาน A= Active  , I = Inactive");
            entity.Property(e => e.R3_TARGET_DATE)
                .HasComment("วันที่ควรได้รับการตอบรับจากลูกค้า คำนวนจาก Send Date+Parameter")
                .HasColumnType("datetime");
            entity.Property(e => e.R3_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ปรับปรุงข้อมูลล่าสุดโดย");
            entity.Property(e => e.R3_UPDATE_DATE)
                .HasComment("วันที่ปรับปรุงข้อมูลล่าสุด")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<T_REPO_NOTE>(entity =>
        {
            entity.HasKey(e => e.NOTE_ID).HasName("PK_T_NOTE");

            entity.Property(e => e.NOTE_ID).HasComment("รหัส Note");
            entity.Property(e => e.NOTE_CONTRACT_NO)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("เลขที่สัญญา");
            entity.Property(e => e.NOTE_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.NOTE_CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.NOTE_JOB_ID)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("T_JOB_REPO.JOB_ID");
            entity.Property(e => e.NOTE_REMARK)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasComment("หมายเหตุ");
            entity.Property(e => e.NOTE_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน");
            entity.Property(e => e.NOTE_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้แก้ไข");
            entity.Property(e => e.NOTE_UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<T_WRITEOFF_D>(entity =>
        {
            entity.HasKey(e => e.WRITEOFFD_ID);

            entity.Property(e => e.WRITEOFFD_ID).HasComment("รหัส Write-off Detail");
            entity.Property(e => e.WRITEOFFD_AUCTION_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะการขายทอดตลาด");
            entity.Property(e => e.WRITEOFFD_BLACKCODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("เลขคดีดำ");
            entity.Property(e => e.WRITEOFFD_CAIMTAX_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะ Write off caim tax");
            entity.Property(e => e.WRITEOFFD_COMPANY_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะ write off company");
            entity.Property(e => e.WRITEOFFD_CONTRACT_NO)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("เลขที่สัญญา");
            entity.Property(e => e.WRITEOFFD_COURTCODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัสศาล");
            entity.Property(e => e.WRITEOFFD_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.WRITEOFFD_CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.WRITEOFFD_ENFORCEMENT_EFF_DATE)
                .HasComment("วันที่ตั้งเรื่องบังคับคดี")
                .HasColumnType("datetime");
            entity.Property(e => e.WRITEOFFD_EXECUTION_DATE)
                .HasComment("วันที่บังคับคดี")
                .HasColumnType("datetime");
            entity.Property(e => e.WRITEOFFD_EXECUTION_END_DATE)
                .HasComment("วันสิ้นสุดบังคับคดี")
                .HasColumnType("datetime");
            entity.Property(e => e.WRITEOFFD_FILING_DATE)
                .HasComment("วันที่ฟ้อง")
                .HasColumnType("datetime");
            entity.Property(e => e.WRITEOFFD_HID)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("T_WRITEOFF_H.WRITEOFF_DOC_ID");
            entity.Property(e => e.WRITEOFFD_JD_TOTAL)
                .HasComment("หนี้ตามคำพิพากษาไม่รวมดอกเบี้ย")
                .HasColumnType("decimal(18, 8)");
            entity.Property(e => e.WRITEOFFD_JUDGMENT_DATE)
                .HasComment("วันที่ศาลพิพากษา")
                .HasColumnType("datetime");
            entity.Property(e => e.WRITEOFFD_LEGAL_STATUS)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("สถานะทางกฎหมาย");
            entity.Property(e => e.WRITEOFFD_OS)
                .HasComment("Outstanding balance")
                .HasColumnType("decimal(18, 8)");
            entity.Property(e => e.WRITEOFFD_OVD_DAY).HasComment("จำนวนวันที่ค้างชำระ");
            entity.Property(e => e.WRITEOFFD_R3_DAY).HasComment("จำนวนวันที่ตอบรับจดหมาย R3");
            entity.Property(e => e.WRITEOFFD_R3_STATUS)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("สถานะการตอบรับจดหมาย R3");
            entity.Property(e => e.WRITEOFFD_REDCODE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("เลขคดีแดง");
            entity.Property(e => e.WRITEOFFD_REMARK)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasComment("หมายเหตุ");
            entity.Property(e => e.WRITEOFFD_REPORT_DATE)
                .HasComment("วันที่ส่งรายงานสืบทรัพย์")
                .HasColumnType("datetime");
            entity.Property(e => e.WRITEOFFD_REPO_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะการยึดรถ");
            entity.Property(e => e.WRITEOFFD_REPO_STATUS)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("สถานะการติดตามและยึดรถ");
            entity.Property(e => e.WRITEOFFD_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน");
            entity.Property(e => e.WRITEOFFD_SUBMIT_ENFORCEMENT_DATE)
                .HasComment("วันทีส่งไปบังคับคดี")
                .HasColumnType("datetime");
            entity.Property(e => e.WRITEOFFD_SUBMIT_INVEST_DATE)
                .HasComment("วันที่ส่งไปสืบทรัพย์")
                .HasColumnType("datetime");
            entity.Property(e => e.WRITEOFFD_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้แก้ไข");
            entity.Property(e => e.WRITEOFFD_UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<T_WRITEOFF_H>(entity =>
        {
            entity.HasKey(e => e.WRITEOFF_DOC_ID);

            entity.Property(e => e.WRITEOFF_DOC_ID)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("รหัสเอกสาร");
            entity.Property(e => e.WRITEOFF_APPROVE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้อนุมัติ");
            entity.Property(e => e.WRITEOFF_APPROVE_DATE)
                .HasComment("วันที่อนุมัติ")
                .HasColumnType("datetime");
            entity.Property(e => e.WRITEOFF_APPROVE_FLAG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะการอนุมัติ W=Pending, A=Approved, R=Rejected");
            entity.Property(e => e.WRITEOFF_CREATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้สร้าง");
            entity.Property(e => e.WRITEOFF_CREATE_DATE)
                .HasComment("วันที่สร้าง")
                .HasColumnType("datetime");
            entity.Property(e => e.WRITEOFF_DATE)
                .HasComment("วันที่ Generate เอกสาร")
                .HasColumnType("datetime");
            entity.Property(e => e.WRITEOFF_STATUS)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("สถานะใช้งาน A=Active,I=Inactive");
            entity.Property(e => e.WRITEOFF_SUBTYPE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("subtype");
            entity.Property(e => e.WRITEOFF_TYPE)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("ประเภท write-off");
            entity.Property(e => e.WRITEOFF_UPDATE_BY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("ผู้ที่แก้ไข");
            entity.Property(e => e.WRITEOFF_UPDATE_DATE)
                .HasComment("วันที่แก้ไข")
                .HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
