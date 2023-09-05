using System;
using System.Collections.Generic;

namespace DemoWebApp.Core.Domain.Entities;

public partial class T_BANKRUPTCY_FRAUD_D
{
    /// <summary>
    /// ลำดับ
    /// </summary>
    public int BFD_ID { get; set; }

    /// <summary>
    /// T_BANKRUPTCY_FRAUD_H.DOC_ID
    /// </summary>
    public string BFD_HID { get; set; }

    /// <summary>
    /// เลขที่สัญญา
    /// </summary>
    public string BFD_CONTRACT_NO { get; set; }

    /// <summary>
    /// เลขบัตรประชาชน
    /// </summary>
    public string BFD_CARD_NO { get; set; }

    /// <summary>
    /// ชื่อ
    /// </summary>
    public string BFD_FIRSTNAME { get; set; }

    /// <summary>
    /// นามสกุล
    /// </summary>
    public string BFD_LASTNAME { get; set; }

    /// <summary>
    /// ชื่อศาล
    /// </summary>
    public string BFD_COURTNAME { get; set; }

    /// <summary>
    /// เลขคดีแดง
    /// </summary>
    public string BFD_REDCODE { get; set; }

    /// <summary>
    /// ชื่อโจทย์
    /// </summary>
    public string BFD_PLAINTIFF_NAME { get; set; }

    /// <summary>
    /// ชื่อจำเลย
    /// </summary>
    public string BFD_DEFENDANT_NAME { get; set; }

    /// <summary>
    /// วันที่ศาลมีคำสั่งพิทักษ์ทรัพย์เด็ดขาด
    /// </summary>
    public DateTime? BFD_RECEIVING_ORDER_DATE { get; set; }

    /// <summary>
    /// วันที่ครบกำหนดยื่นคำขอรับชำระหนี้
    /// </summary>
    public DateTime? BFD_SUBMIT_DUE_DATE { get; set; }

    /// <summary>
    /// วันที่ศาลมีคำสั่งเพิกถอนพิทักษ์ทรัพย์เด็ดขาด
    /// </summary>
    public DateTime? BFD_CANCEL_RECEIVING_ORDER_DATE { get; set; }

    /// <summary>
    /// วันที่ประนอมหนี้ก่อนล้มละลาย
    /// </summary>
    public DateTime? BFD_COMPROMISE_BEFORE_DATE { get; set; }

    /// <summary>
    /// วันที่ยกเลิกประนอมหนี้ก่อนล้มและพิพากษาให้ล้มละลาย
    /// </summary>
    public DateTime? BFD_CANCEL_COMPROMISE_BAFORE_DATE { get; set; }

    /// <summary>
    /// วันที่ศาลมีคำสั่งพิพากษาให้ล้มละลาย
    /// </summary>
    public DateTime? BFD_ORDER_BANKRUPCTY_DATE { get; set; }

    /// <summary>
    /// วันที่ประนอมหนี้หลังล้มละลาย
    /// </summary>
    public DateTime? BFD_COMPROMISE_AFTER_DATE { get; set; }

    /// <summary>
    /// วันที่ยกเลิกประนอมหนี้หลังล้มและพิพากษาให้ล้มละลาย
    /// </summary>
    public DateTime? BFD_CANCEL_COMPROMISE_AFTER_DATE { get; set; }

    /// <summary>
    /// วันที่ครบกำหนดยื่นคำขอรับชำระหนี้หลังล้ม
    /// </summary>
    public DateTime? BFD_SUBMIT_AFTER_DUE_DATE { get; set; }

    /// <summary>
    /// วันที่ยกเลิกการล้มละลาย
    /// </summary>
    public DateTime? BFD_CANCEL_BANKRUPTCY_DATE { get; set; }

    /// <summary>
    /// วันที่ปลดจากการเป็นบุคคลล้มละลาย
    /// </summary>
    public DateTime? BFD_DISCHANGED_BANKRUPTCY_DATE { get; set; }

    /// <summary>
    /// วันที่ยกฟ้อง
    /// </summary>
    public DateTime? BFD_DISMISSAL_DATE { get; set; }

    /// <summary>
    /// วันที่จำหน่ายคดี
    /// </summary>
    public DateTime? BFD_DISPOSE_CASE_DATE { get; set; }

    /// <summary>
    /// วันที่ฟ้อง
    /// </summary>
    public DateTime? BFD_FILING_DATE { get; set; }

    /// <summary>
    /// หมายเหตุ
    /// </summary>
    public string BFD_REMARK { get; set; }

    /// <summary>
    /// ผู้สร้าง
    /// </summary>
    public string BFD_CREATE_BY { get; set; }

    /// <summary>
    /// วันที่สร้าง
    /// </summary>
    public DateTime? BFD_CREATE_DATE { get; set; }

    /// <summary>
    /// ผู้แก้ไข
    /// </summary>
    public string BFD_UPDATE_BY { get; set; }

    /// <summary>
    /// วันที่แก้ไข
    /// </summary>
    public DateTime? BFD_UPDATE_DATE { get; set; }

    /// <summary>
    /// สถานะใช้งาน A=Active,I=Inactive
    /// </summary>
    public string BFD_STATUS { get; set; }
}
