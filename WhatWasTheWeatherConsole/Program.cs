﻿using System;
using WhatWasTheWeather;

namespace WhatWasTheWeatherConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherService weatherService = new WeatherService();
            weatherService.getWeatherForDate(new DateTime(), 60185);
            Console.WriteLine();
        }
    }
}