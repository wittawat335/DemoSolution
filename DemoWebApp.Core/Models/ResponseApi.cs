using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebApp.Core.Models
{
    public class ResponseApi<T>
    {
        public T Value { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public string returnUrl { get; set; }
    }
}
