using System;

namespace Adapter.Classes
{
    public class Duck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("I am flying");
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}