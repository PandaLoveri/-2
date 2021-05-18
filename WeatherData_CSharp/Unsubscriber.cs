using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherData_CSharp
{
    internal class Unsubscriber<WeatherInfo>: IDisposable
    {
        private List<IObserver<WeatherInfo>> _observers;
        private IObserver<WeatherInfo> _observer;

        internal Unsubscriber(List<IObserver<WeatherInfo>> observers, IObserver<WeatherInfo> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (_observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}
