using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherData
{
    public class Data
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private float oxygen_percentage;
        private float precipitation;
        private bool is_fog;

        public void Display()
        {

            string s = $"Температура: {temperature}°C\n" +
                $"Влажность: {humidity}%\n" +
                $"Давление: {pressure} мм.рт.ст\n" +
                $"Процент кислорода: {oxygen_percentage}%\n" +
                $"Количество осадков: {precipitation}%\n" +
                $"Наличие тумана: ";
            s += is_fog ? "есть" : "нет";
            Console.WriteLine(s);
        }

        public void SetMeasurements(float temperature, float humidity, float pressure, float oxygen_percentage, float precipitation, bool is_fog)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            this.oxygen_percentage = oxygen_percentage;
            this.precipitation = precipitation;
            this.is_fog = is_fog;
        }
    }
}
