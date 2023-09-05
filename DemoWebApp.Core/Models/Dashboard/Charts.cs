using DemoWebApp.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebApp.Core.Models.Dashboard
{
    public class Charts
    {
        public string id { get; set; }
        public string text { get; set; }
        public int value { get; set; }
        public string color { get; set; }
    }

    public class ChartsSP
    {
        public ChartsSP()
        {
            repo = new List<T_JOB_REPO>();
        }

        public string ID { get; set; }
        public string TEXT { get; set; }
        public int VALUE { get; set; }
        public string COLOR { get; set; }
        List<T_JOB_REPO> repo { get; set; }
    }
}
