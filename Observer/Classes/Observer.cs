using System;

namespace Observer.Classes
{
    public class Observer : IObserver
    {
        private string _name;

        public Observer(string name)
        {
            _name = name;
        }

        public void Update(double temp, double pressure, double humidity)
        {
            Console.WriteLine($"{_name} Temp: {temp}, Pressure: {pressure}, Humidity: {humidity}");
        }
    }
}
