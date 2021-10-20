using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1.Models.QuotationModels
{
    public class Root
    {
        public List<Quote> Quotes { get; set; }
        public List<Carrier> Carriers { get; set; }
        public List<Place> Places { get; set; }
        public List<Currency> Currencies { get; set; }

        public Root()
        {
            this.Quotes = new List<Quote>();
            this.Carriers = new List<Carrier>();
            this.Places = new List<Place>();
            this.Currencies = new List<Currency>();
        }
    }
}
