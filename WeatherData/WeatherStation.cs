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

            weatherData.setMeasurements(80, 65, 30);
            weatherData.setMeasurements(90, 75, 10);
            weatherData.setMeasurements(60, 25, 40);
        }
    }
}
