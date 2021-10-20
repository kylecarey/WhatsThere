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
        public OutboundLeg OutboundLeg { get; set; }
        public DateTime QuoteDateTime { get; set; }

        public Quote()
        {
        }

        public override string ToString()
        {
            return "\nQuoteId: " + QuoteId + "\n" +
                "MinPrice: " + MinPrice + "\n" +
                "Direct: " + Direct + "\n" +
                "OutboundLeg: " + OutboundLeg.DepartureDate + "\n" +
                "QuoteDateTime: " + QuoteDateTime;
        }
    }
}
