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
            //Exercise 1 implementation
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"Kanye Quote {i + 1}: {quote.Kanye()}");
            //    Console.WriteLine($"Ron Swanson Quote {i + 1}: {quote.RonSwanson()}");
            //}





            Console.WriteLine("Please enter in api key.");
            var apiKey = Console.ReadLine();
            while(true)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter in the city name");
                var cityName = Console.ReadLine();
                var weatherURL = "";

                var response = client.GetStringAsync(weatherURL).Result;
                //var formattedResponse = JValue.Parse(response).GetValue("main").ToString();
                Console.WriteLine(response);
                Console.WriteLine();

            }
        }
    }
}



//Create an OpenWeatherMap account to get a free API Key
//Add the NewtonSoft.Json Nuget Package to your Console App
//Figure out how to get the CURRENT weather for the City you specify in degrees fahrenheit
//Use this site for extra help: https://openweathermap.org/current  
//Creatively display &organize the response
