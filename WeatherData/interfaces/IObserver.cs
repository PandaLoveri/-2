﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherData.interfaces
{
    public interface IObserver
    {
        public void update(float temp, float humanity, float pressure);
    }
}
