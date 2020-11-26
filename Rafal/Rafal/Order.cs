using System;
using System.Collections.Generic;
using System.Text;

namespace Rafal
{
    public class Order
    {
        public int ID { get; set; }
        public string ClientName { get; set; }
        public string Name { get; set; }
        public String OrderDate { get; set; }
        public DateTime EndOrderDate { get; set; }
        public bool IsStep1Done { get; set; }
        public bool IsStep2Done { get; set; }
        public bool IsStep3Done { get; set; }
        public bool IsStep4Done { get; set; }
        public bool IsReady { get; set; }
        public string CreatorName { get; set; }

    }
}
