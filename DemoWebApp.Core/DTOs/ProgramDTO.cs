using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebApp.Core.DTOs
{
    public class ProgramDTO
    {
        /// <summary>
        /// รหัสโปรแกรม
        /// </summary>
        public string PROG_CODE { get; set; } = null!;

        /// <summary>
        /// ชื่อโปรแกรม
        /// </summary>
        public string PROG_NAME { get; set; }

        /// <summary>
        /// เลเวล
        /// </summary>
        public int? PROG_LEVEL { get; set; }

        /// <summary>
        /// เป็นลูกของโปรแกรม
        /// </summary>
        public string PROG_PARENT_CODE { get; set; }

        /// <summary>
        /// Url
        /// </summary>
        public string PROG_TARGET_URL { get; set; }

        /// <summary>
        /// เรียงลำดับ
        /// </summary>
        public int? PROG_ORDER { get; set; }

        /// <summary>
        /// ชื่อ icon
        /// </summary>
        public string PROG_ICON { get; set; }

        /// <summary>
        /// ผู้สร้าง
        /// </summary>
        public string PROG_CREATE_BY { get; set; }

        /// <summary>
        /// วันที่สร้าง
        /// </summary>
        public DateTime? PROG_CREATE_DATE { get; set; }

        /// <summary>
        /// ผู้แก้ไข
        /// </summary>
        public string PROG_UPDATE_BY { get; set; }

        /// <summary>
        /// วันที่แก้ไข
        /// </summary>
        public DateTime? PROG_UPDATE_DATE { get; set; }

        /// <summary>
        /// สถานะข้อมูล A=ใช้งาน,I=ไม่ใช้งาน
        /// </summary>
        public string PROG_STATUS { get; set; }
    }
}
