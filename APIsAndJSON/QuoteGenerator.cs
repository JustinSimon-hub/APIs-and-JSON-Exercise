using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class QuoteGenerator
    {
        private HttpClient _client;
        public QuoteGenerator(HttpClient client)
        {
            _client = client;
        }
        public string Kanye()
        {
            //API Url
           var kanye = "https://api.kanye.rest/";
            //Stores the Json response in a variable
            var kanyeResponse = _client.GetStringAsync(kanye).Result;
            //Pares through the response we recieved to get the value associated with the Name object
            var kanyeQuote = JObject.Parse(kanyeResponse)["quote"].ToString();

            return kanyeQuote;

        }

        public string RonSwanson()
        {
            //Ron swanson API Url 
            var ronSwanson = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronReponse = _client.GetStringAsync(ronSwanson).Result;
            var ronQuote = JArray.Parse(ronReponse)[0].ToString();
            return ronQuote;
        }

    }
}
