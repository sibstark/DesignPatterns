using System;

namespace Observer.Events.Classes
{
    public class Subject : ISubject
    {
        private delegate void NotifyHandler(double temp, double pressure, double humidity);
        private event NotifyHandler NotifyEvent;

        public void Notify()
        {
            throw new NotImplementedException();
        }

        public void RegisterObserver(IObserver o)
        {
            NotifyEvent += o.Update;
        }

        public void RemoveObserver(IObserver o)
        {
            NotifyEvent -= o.Update;
        }

        public void SetState(double temp, double pressure, double humidity)
        {
            NotifyEvent?.Invoke(temp, pressure, humidity);
        }
    }
}
