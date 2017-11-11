using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var isntance = Singleton.Classes.Singleton.Instance;
            isntance.Name = "Instance";

            Console.WriteLine(isntance.Name);

            var secondIsntance = Singleton.Classes.Singleton.Instance;

            Console.WriteLine(secondIsntance.Name);            
        }
    }
}
