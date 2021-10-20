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
using CA1.Models.QuotationModels;
using Newtonsoft.Json;
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

        public void GetQuotes(string originPlace, string destinationPlace, DateTime outboundDate, DateTime inboundDate)
        {
            // Formatting Dates
            string outbound = outboundDate.ToString("yyyy-MM-dd");
            string inbound = inboundDate.ToString("yyyy-MM-dd");

            var client = new RestClient("https://skyscanner-skyscanner-flight-search-v1.p.rapidapi.com/apiservices/browsequotes/v1.0/IE/EUR/en-GB/" + originPlace + "/" + destinationPlace + "/" + outbound);
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "skyscanner-skyscanner-flight-search-v1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "00c989c312mshd8a182e8bd8745dp1b0333jsn6045bc5f73e0");

            // Adding parameters
            request.AddParameter("inboundpartialdate", inbound);

            // Executing Response
            var response = client.Execute(request);

            // Deserializing
            JsonDeserializer jd = new JsonDeserializer();
            Root output = jd.Deserialize<Root>(response);
            var quotes = output.Quotes;

            if(quotes.Count != 0)
            {
                foreach (Quote q in quotes)
                {
                    quoteOutputTextbox.Text += "\n" + q.ToString();
                }
            }
            else
            {
                Console.WriteLine("nothing available");
            }
            
            
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
            string placename = ((SearchPlace)e.ListItem).PlaceName;
            string countryname = ((SearchPlace)e.ListItem).CountryName;
            e.Value = placename + ", " + countryname;
        }

        private void flyingToComboFormat(object sender, ListControlConvertEventArgs e)
        {
            string placename = ((SearchPlace)e.ListItem).PlaceName;
            string countryname = ((SearchPlace)e.ListItem).CountryName;
            string placeid = ((SearchPlace)e.ListItem).PlaceId;
            e.Value = placename + ", " + countryname;
        }

        private void getQuotesButton_Click(object sender, EventArgs e)
        {
            SearchPlace dep = (SearchPlace)departureCombo.SelectedItem;

            SearchPlace fly = (SearchPlace)flyingToCombo.SelectedItem;

            DateTime outboundDate = departureDate.Value.Date;
            DateTime inboundDate = destinationDate.Value.Date;

            GetQuotes(dep.PlaceId, fly.PlaceId, outboundDate, inboundDate);

        }
    }
}
