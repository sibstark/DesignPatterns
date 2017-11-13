namespace Memento.Classes
{
    public class HeroMemento
    {
        public int Patrons { get; }
        public int Lives { get; }

        public HeroMemento(int patrons, int lives)
        {
            Patrons = patrons;
            Lives = lives;
        }
    }
}