using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
          var client = new HttpClient();
          var quote = new QuoteGenerator(client);

            //interate through 5 quotes from each API
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Kanye Quote {i + 1}: {quote.Kanye()}");
                Console.WriteLine($"Ron Swanson Quote {i + 1}: {quote.RonSwanson()}");
            }
        }
    }
}
