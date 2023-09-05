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
        [Display(Name = "Username")]
        public string USER_LOGIN { get; set; } = null!;
        [Display(Name = "Password")]
        public string USER_PASSWORD { get; set; }

        [Display(Name = "First Name")]
        public string USER_FIRST_NAME { get; set; }

        [Display(Name = "Last Name")]
        public string USER_LAST_NAME { get; set; }
        [Display(Name = "Type")]
        public string USER_AD_FLAG { get; set; }
        public string USER_CREATE_BY { get; set; }
        public DateTime USER_CREATE_DATE { get; set; }
        public string USER_UPDATE_BY { get; set; }
        public DateTime USER_UPDATE_DATE { get; set; }
        [Display(Name = "Status")]
        public string USER_STATUS { get; set; }
    }
}
