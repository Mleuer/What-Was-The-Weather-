using System.Collections.Generic;

namespace WhatWasTheWeather.Models
{
    public class Astronomy
    {
        public string sunrise { get; set; }
        public string sunset { get; set; }
        public string moonrise { get; set; }
        public string moonset { get; set; }
        public string moon_phase { get; set; }
        public string moon_illumination { get; set; }
    }

    public class WeatherIconUrl
    {
        public string value { get; set; }
    }

    public class WeatherDesc
    {
        public string value { get; set; }
    }

    public class Hourly
    {
        public string time { get; set; }
        public string tempC { get; set; }
        public string tempF { get; set; }
        public string windspeedMiles { get; set; }
        public string windspeedKmph { get; set; }
        public string winddirDegree { get; set; }
        public string winddir16Point { get; set; }
        public string weatherCode { get; set; }
        public List<WeatherIconUrl> weatherIconUrl { get; set; }
        public List<WeatherDesc> weatherDesc { get; set; }
        public string precipMM { get; set; }
        public string precipInches { get; set; }
        public string humidity { get; set; }
        public string visibility { get; set; }
        public string visibilityMiles { get; set; }
        public string pressure { get; set; }
        public string pressureInches { get; set; }
        public string cloudcover { get; set; }
        public string HeatIndexC { get; set; }
        public string HeatIndexF { get; set; }
        public string DewPointC { get; set; }
        public string DewPointF { get; set; }
        public string WindChillC { get; set; }
        public string WindChillF { get; set; }
        public string WindGustMiles { get; set; }
        public string WindGustKmph { get; set; }
        public string FeelsLikeC { get; set; }
        public string FeelsLikeF { get; set; }
        public string uvIndex { get; set; }
    }

    public class Weather
    {
        public string date { get; set; }
        public List<Astronomy> astronomy { get; set; }
        public string maxtempC { get; set; }
        public string maxtempF { get; set; }
        public string mintempC { get; set; }
        public string mintempF { get; set; }
        public string avgtempC { get; set; }
        public string avgtempF { get; set; }
        public string totalSnow_cm { get; set; }
        public string sunHour { get; set; }
        public string uvIndex { get; set; }
        public List<Hourly> hourly { get; set; }
    }
}