namespace Observer.Classes
{
    public interface ISubject
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void Notify();
        void SetState(double temp, double pressure, double humidity);
    }
}
