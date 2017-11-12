using System;

namespace Strategy.Classes
{
    public class PetrolMove : IMove
    {
        public void Move()
        {
            Console.WriteLine("Petrol move");
        }
    }
}