namespace Observer.Events.Classes
{
    public class Subject : ISubject
    {
        private delegate void NotifyHandler(double temp, double pressure, double humidity);
        private event NotifyHandler NotifyEvent;
        private double _temp;
        private double _pressure;
        private double _humidity;

        public void Notify()
        {
            NotifyEvent?.Invoke(_temp, _pressure, _humidity);
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
            _humidity = humidity;
            _temp = temp;
            _pressure = pressure;
            NotifyEvent?.Invoke(_temp, _pressure, _humidity);
        }
    }
}
