using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraspagMedigitalAPI.Objects
{
    public class RecurrentPayment
    {
        public bool AuthorizeNow { get; set; }
        public string EndDate { get; set; }
        public string Interval { get; set; }
        public string StartDate { get; set; }

        public string RecurrentPaymentId { get; set; }
        public string ReasonCode { get; set; }
        public string ReasonMessage { get; set; }
        public string NextRecurrency { get; set; }
        public Link Link { get; set; }
    }

}
