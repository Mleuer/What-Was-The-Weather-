using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WhatWasTheWeather.Models;

namespace WhatWasTheWeatherConsole
{
    public class WeatherService
    {
        private static readonly Uri worldWeatherServiceURL = new Uri("http://api.worldweatheronline.com");
        private HttpClient Client = new HttpClient(){ BaseAddress = worldWeatherServiceURL};

        public Weather getWeatherForDate(DateTime date, int zipCode)
        {
             var request = Client.GetAsync("/premium/v1/past-weather.ashx?key=f4db177bb3bc4d91900234125191908&q=60185&date=2009-04-08&format=json");
             HttpResponseMessage responseMessage = request.Result;
             HttpContent responseContent = responseMessage.Content;
             Task<Stream> task = responseContent.ReadAsStreamAsync();
             Stream stream = task.Result;
             String responseBody = new StreamReader(stream).ReadToEnd();
             JObject responseJSON = JObject.Parse(responseBody);
             JToken serializedWeather = responseJSON["data"]["weather"];

             if (serializedWeather is JArray weatherEntries)
             {
                 Weather weather = JsonConvert.DeserializeObject<Weather>(weatherEntries[0].ToString());
                 return weather;
             }
             throw new Exception("Could not retrieve weather");
        }
        
    }
}