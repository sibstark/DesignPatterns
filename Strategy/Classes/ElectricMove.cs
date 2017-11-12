using System;

namespace Strategy.Classes
{
    public class ElectricMove : IMove
    {
        public void Move()
        {
            Console.WriteLine("Electric move");
        }
    }
}