using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1.Models
{
    public class Quote
    {
        public int QuoteId { get; set; }
        public int MinPrice { get; set; }
        public bool Direct { get; set; }
        public OutboundLeg OutboundLeg {get; set;}
        public InboundLeg InboundLeg { get; set; }
        public DateTime QuoteDateTime { get; set; }
    }

    public class OutboundLeg
    {
        public int[] CarrierIds { get; set; }
        public int OriginId { get; set;}
        public int DestinationId { get; set; }
        public DateTime DepartureDate { get; set; }
    }

    public class InboundLeg
    {
        public int[] CarrierIds { get; set; }
        public int OriginId { get; set; }
        public int DestinationId { get; set; }
        public DateTime DepartureDate { get; set; }
    }
}
