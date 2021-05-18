using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherData_CSharp
{
    public class WeatherHandler: IObservable<WeatherInfo>
    {
        private List<IObserver<WeatherInfo>> observers;
        private WeatherInfo condition;

        public WeatherHandler()
        {
            observers = new List<IObserver<WeatherInfo>>();
            condition = new WeatherInfo();
        }

        public IDisposable Subscribe(IObserver<WeatherInfo> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
                observer.OnNext(condition);
            }
            return new Unsubscriber<WeatherInfo>(observers, observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver<WeatherInfo> observer in observers)
            {
                observer.OnNext(condition);
            }
        }

        public void WeatherStatus(float temperature, float humidity, float pressure, float oxygen_percentage, float precipitation, bool is_fog)
        {
            condition = new WeatherInfo(temperature, humidity, pressure, oxygen_percentage, precipitation, is_fog);
            NotifyObservers();
        }

    }
}
