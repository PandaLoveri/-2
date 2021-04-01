using System;
using System.Collections.Generic;
using System.Text;
using WeatherData.interfaces;

namespace WeatherData
{
    public class CurrentConditionsDisplay: IObserver, IDisplay
    {
        private float temperature;
        private float humidity;
        private ISubject weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void display()
        {            
            Console.WriteLine($"Сейчас на улице { this.temperature} градусов и { this.humidity} процентов влажности");
        }

        public void update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            display();
        }

    }
}
