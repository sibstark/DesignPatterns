using System;
using Memento.Classes;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            GameHistory game = new GameHistory();
            Hero hero = new Hero();
            hero.Shoot();
            hero.Shoot();
            hero.Shoot();
            game.History.Push(hero.SaveState());
            hero.Shoot();
            hero.Shoot();
            hero.Shoot();
            hero.RestoreState(game.History.Pop());
            hero.Shoot();
            Console.Read();
        }
    }
}
