using System;
using System.Collections.Generic;
using System.Text;
using WeatherData.interfaces;

namespace WeatherData
{
    public class CurrentConditionsDisplay: IObserver, IDisplay
    {
        private Data data;
        private ISubject weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            this.data.Display();
        }

        public void Update(Data data)
        {
            this.data = data;
            Display();
        }

    }
}
