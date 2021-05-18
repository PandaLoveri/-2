using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherData_CSharp
{
    public class WeatherInfo
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private float oxygen_percentage;
        private float precipitation;
        private bool is_fog;

        public WeatherInfo() { }
        internal WeatherInfo(float temperature, float humidity, float pressure, float oxygen_percentage, float precipitation, bool is_fog)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            this.oxygen_percentage = oxygen_percentage;
            this.precipitation = precipitation;
            this.is_fog = is_fog;
        }

        public float Temperature
        {
            get { return this.temperature; }
        }

        public float Humidity
        {
            get { return this.humidity; }
        }

        public float Pressure
        {
            get { return this.pressure; }
        }

        public float Oxygen_percentage
        {
            get { return this.oxygen_percentage; }
        }

        public float Precipitation
        {
            get { return this.precipitation; }
        }

        public bool Is_fog
        {
            get { return this.is_fog; }
        }
    }
}
