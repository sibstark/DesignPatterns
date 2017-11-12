using System;
using Strategy.Classes;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var auto = new Car(new PetrolMove(), 4);
            auto.Move();
            auto.Movable = new ElectricMove();
            auto.Move();

            Console.ReadLine();
        }
    }
}
