using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebApp.Core.DTOs
{
    public class UserDTO
    {
        /// <summary>
        /// LoginUser จาก AD
        /// </summary>
        public string USER_LOGIN { get; set; }

        public string USER_PASSWORD { get; set; }

        /// <summary>
        /// ชื่อ
        /// </summary>
        public string USER_FIRST_NAME { get; set; }

        /// <summary>
        /// นามสกุล
        /// </summary>
        public string USER_LAST_NAME { get; set; }

        public string USER_AD_FLAG { get; set; }

        /// <summary>
        /// ผู้สร้าง
        /// </summary>
        public string USER_CREATE_BY { get; set; }

        /// <summary>
        /// วันที่สร้าง
        /// </summary>
        public DateTime? USER_CREATE_DATE { get; set; }

        /// <summary>
        /// ผู้แก้ไข
        /// </summary>
        public string USER_UPDATE_BY { get; set; }

        /// <summary>
        /// วันที่แก้ไข
        /// </summary>
        public DateTime? USER_UPDATE_DATE { get; set; }

        /// <summary>
        /// สถานะข้อมูล
        /// </summary>
        public string USER_STATUS { get; set; }
    }
}
