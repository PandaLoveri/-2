using System;

namespace WeatherData_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherHandler provider = new WeatherHandler();
            CurrentConditionDisplay currentDisplay = new CurrentConditionDisplay();

            provider.WeatherStatus(80, 65, 30, 25, 20, true);
            currentDisplay.Subscribe(provider);
            Console.WriteLine();

            provider.WeatherStatus(90, 75, 10, 35, 20, false);
            currentDisplay.Subscribe(provider);
            Console.WriteLine();

            provider.WeatherStatus(60, 25, 40, 5, 20, true);
            currentDisplay.Subscribe(provider);

        }
    }
}
