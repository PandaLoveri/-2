using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherData.interfaces
{
    public interface ISubject
    {
        public void registerObserver(IObserver o);
        public void removeObserver(IObserver o);
        public void notifyObservers();
    }
}
