using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CA1.Models;
using RestSharp;
using RestSharp.Serialization.Json;

namespace CA1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Search by country name
        public void ListPlaces(string input, bool departing) // using boolean to decide which combo box to populate
        {
            var client = new RestClient("https://skyscanner-skyscanner-flight-search-v1.p.rapidapi.com/apiservices/autosuggest/v1.0/IE/EUR/en-GB/");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "skyscanner-skyscanner-flight-search-v1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "00c989c312mshd8a182e8bd8745dp1b0333jsn6045bc5f73e0");

            // Adding Parameters
            request.AddParameter("query", input);
            request.AddParameter("country", "IE");
            request.AddParameter("currency", "EUR");
            request.AddParameter("locale", "en-GB");

            // Executing response
            IRestResponse response = client.Execute(request);

            // Deserializing
            JsonDeserializer jd = new JsonDeserializer();
            Places output = jd.Deserialize<Places>(response);
            var places = output.places;

            // Binding
            var bindingsrc = new BindingSource();
            bindingsrc.DataSource = places;

            if (departing)
            {
                departureCombo.DataSource = bindingsrc.DataSource;
                departureCombo.DisplayMember = "PlaceName";
                departureCombo.ValueMember = "PlaceId";
            } else
            {
                flyingToCombo.DataSource = bindingsrc.DataSource;
                flyingToCombo.DisplayMember = "PlaceName";
                flyingToCombo.ValueMember = "PlaceId";
            }
        }

        public void GetQuotes(string originPlace, string destinationPlace, DateFormat outboundDate, DateFormat inboundDate)
        {
            var client = new RestClient("https://skyscanner-skyscanner-flight-search-v1.p.rapidapi.com/browsequotes/autosuggest/v1.0/IE/EUR/en-GB/");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "skyscanner-skyscanner-flight-search-v1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "00c989c312mshd8a182e8bd8745dp1b0333jsn6045bc5f73e0");

            // Adding parameters
            request.AddParameter("originplace", originPlace);
            request.AddParameter("destinationplace", destinationPlace);
            request.AddParameter("outboundpartialdate", outboundDate);
            request.AddParameter("inboundpartialdate", inboundDate);

            // Executing Response
            IRestResponse response = client.Execute(request);

            // Deserializing
            JsonDeserializer jd = new JsonDeserializer();
            QuotationResult output = jd.Deserialize<QuotationResult>(response);
            var places = output.Places;
            var quotes = output.Quotes;
            var carriers = output.Carriers;
            var currencies = output.Currencies;




        }

        private void departureSearchButton_Click(object sender, EventArgs e)
        {
            var input = departureInput.Text;
            ListPlaces(input, true);
        }

        private void flyingToSearchButton_Click(object sender, EventArgs e)
        {
            var input = flyingToInput.Text;
            ListPlaces(input, false);
        }

        private void departureComboFormat(object sender, ListControlConvertEventArgs e)
        {
            string placename = ((Place)e.ListItem).PlaceName;
            string countryname = ((Place)e.ListItem).CountryName;
            e.Value = placename + ", " + countryname;
        }

        private void flyingToComboFormat(object sender, ListControlConvertEventArgs e)
        {
            string placename = ((Place)e.ListItem).PlaceName;
            string countryname = ((Place)e.ListItem).CountryName;
            string placeid = ((Place)e.ListItem).PlaceId;
            e.Value = placename + ", " + countryname;
        }

        // Classes for making an iterable list of objects
        public class Quotes
        {
            public IList<Quote> quotes;
        }
        public class Carriers
        {
            public IList<Carrier> carriers;
        }
        public class Currencies
        {
            public IList<Currency> currencies;
        }
        public class QuotationResult
        {
            public Quotes Quotes { get; set; }
            public Places Places { get; set; }
            public Carriers Carriers { get; set; }
            public Currencies Currencies { get; set; }
        }
    }
}
