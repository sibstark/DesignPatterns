using System.Collections.Generic;

namespace Observer.Classes
{
    public sealed class Subject : ISubject
    {
        private List<IObserver> _observers  = new List<IObserver>();
        private double _temp;
        private double _pressure;
        private double _humidity;

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temp, _pressure, _humidity);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }

        public void SetState(double temp, double pressure, double humidity)
        {
            _temp = temp;
            _pressure = pressure;
            _humidity = humidity;
            Notify();
        }
    }
}
