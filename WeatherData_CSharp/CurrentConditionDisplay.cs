using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherData_CSharp
{
    class CurrentConditionDisplay : IObserver<WeatherInfo>
    {
        private IDisposable cancellation;
        private string weatherInfo;

        public virtual void Subscribe(WeatherHandler provider)
        {
            cancellation = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            cancellation.Dispose();
        }

        public virtual void OnCompleted() { }

        public virtual void OnError(Exception e) { }

        public virtual void OnNext(WeatherInfo info)
        {
            weatherInfo = $"Температура: {info.Temperature}°C\n" +
                $"Влажность: {info.Humidity}%\n" +
                $"Давление: {info.Pressure} мм.рт.ст\n" +
                $"Процент кислорода: {info.Oxygen_percentage}%\n" +
                $"Количество осадков: {info.Precipitation}%\n" +
                $"Наличие тумана: ";
            weatherInfo += info.Is_fog ? "есть" : "нет";
            Console.WriteLine(weatherInfo);
        }
    }
}
