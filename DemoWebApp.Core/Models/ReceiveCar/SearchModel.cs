using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebApp.Core.Models.ReceiveCar
{
    public class SearchModel
    {
        public string refNo { get; set; }
        public string contractNo { get; set; }
        public string borrowerName { get; set; }
        public string admin { get; set; }
        public string status { get; set; }
        public string legal { get; set; }
        public string dataStatus { get; set; }
        public string assignDateForm { get; set; }
        public string assignDateTo { get; set; }
        public bool searchDefault { get; set; }
    }
}
