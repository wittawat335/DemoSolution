using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebApp.Core.DTOs
{
    public class MasterDTO
    {
        /// <summary>
        /// รหัส
        /// </summary>
        [Required(ErrorMessage = "Please insert Master Code")]
        [Display(Name = "Master Code")]
        public string MASTER_CODE { get; set; } = null!;

        /// <summary>
        /// ประเภท
        /// </summary>
        [Display(Name = "Master Type")]
        public string MASTER_TYPE { get; set; } = null!;

        /// <summary>
        /// ชื่อไทย
        /// </summary>
        [Display(Name = "Name (Thai)")]
        public string MASTER_NAME_TH { get; set; }

        /// <summary>
        /// ชื่ออังกฤษ
        /// </summary>
        [Display(Name = "Name (Eng)")]
        public string MASTER_NAME_EN { get; set; }

        /// <summary>
        /// ผู้สร้าง
        /// </summary>
        public string MASTER_CREATE_BY { get; set; }

        /// <summary>
        /// วันที่สร้าง
        /// </summary>
        public DateTime MASTER_CREATE_DATE { get; set; }

        /// <summary>
        /// ผู้แก้ไข
        /// </summary>
        //[Display(Name = "Name (Eng)")]
        public string MASTER_UPDATE_BY { get; set; }

        /// <summary>
        /// วันที่แก้ไข
        /// </summary>
        //[Display(Name = "Name (Eng)")]
        public DateTime? MASTER_UPDATE_DATE { get; set; }

        /// <summary>
        /// สถานะ
        /// </summary>
        [Display(Name = "Status")]
        public string MASTER_STATUS { get; set; }
    }
}
