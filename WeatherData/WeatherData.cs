using System;
using System.Collections.Generic;
using System.Text;
using WeatherData.interfaces;

namespace WeatherData
{
    public class WeatherData :ISubject
    {
        private List<IObserver> observers;
        private Data data;

        public WeatherData()
        {
            observers = new List<IObserver>();
            data = new Data();
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            int removeIndex = observers.IndexOf(o);
            if (removeIndex >= 0)
            {
                observers.RemoveAt(removeIndex);
            }
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(this.data);
            }           
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure, float oxygen_percentage, float precipitation, bool is_fog)
        {
            this.data.SetMeasurements(temperature, humidity, pressure, oxygen_percentage, precipitation, is_fog);
            MeasurementsChanged();
        }
    }
}
