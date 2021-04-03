using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherData
{
    public class WeatherStation
    {
        public static void Main(String[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30, 25, 20, true);
            weatherData.SetMeasurements(90, 75, 10, 35, 20, false);
            weatherData.SetMeasurements(60, 25, 40, 5, 20, true);
        }
    }
}
