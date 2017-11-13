using System;

namespace Memento.Classes
{
    public class Hero
    {
        private int patrons = 10;
        private int lives = 10;

        public void Shoot()
        {
            if (patrons > 0)
            {
                patrons--;
                Console.WriteLine("Shooting. {0} patrons", patrons);
            }
            else
            {
                Console.WriteLine("No patrons");
            }
        }

        public HeroMemento SaveState()
        {
            Console.WriteLine("Saving. Params: {0} patrons, {1} lives", patrons, lives);
            return new HeroMemento(patrons, lives);
        }

        public void RestoreState(HeroMemento memento)
        {
            patrons = memento.Patrons;
            lives = memento.Lives;
            Console.WriteLine("Restoring. Params: {0} patrons, {1} lives", patrons, lives);
        }
    }
}