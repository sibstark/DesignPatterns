using System;
using Facade.Classes;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var theater = new HomeTheaterFacade(new PopcornMachine(), new Tuner(), new DvdPlayer(), new Projector(), new Screen());
            theater.WatchMovie();
            theater.EndMovie();
        }
    }
}
