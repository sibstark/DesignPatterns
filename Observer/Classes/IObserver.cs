namespace Observer.Classes
{
    public interface IObserver
    {
        void Update(double temp, double pressure, double humidity);
    }
}