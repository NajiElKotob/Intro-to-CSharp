using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

/*
Call a Web API From a .NET Client (C#)
https://docs.microsoft.com/en-us/aspnet/web-api/overview/advanced/calling-a-web-api-from-a-net-client
*/

namespace WeatherForecast_Web_API_Client
{
    class Program
    {

        static async Task RunAsync()
        {
            using (var client = new HttpClient())
            {
                var WebAPIUri = "http://localhost:64666/";
                Console.WriteLine($"Connecting to {WebAPIUri}");
                // Update port # in the following line.
                client.BaseAddress = new Uri(WebAPIUri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                //HTTP GET

                //IEnumerable<WeatherForecast> weatherForecast = null;
                HttpResponseMessage response = await client.GetAsync("/weatherforecast");
                if (response.IsSuccessStatusCode)
                {
                    var weatherForecast = await response.Content.ReadAsAsync<IEnumerable<WeatherForecast>>();
                    foreach (var item in weatherForecast)
                    {
                        Console.WriteLine($"{item.ToString()}");
                    }
                }

            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            RunAsync().GetAwaiter().GetResult();
        }


        public class WeatherForecast
        {
            public DateTime Date { get; set; }

            public int TemperatureC { get; set; }

            public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

            public string Summary { get; set; }

            public override string ToString()
            {
                return $"{Date:G}: {Summary} {TemperatureC}c";
            }
        }
    }
}