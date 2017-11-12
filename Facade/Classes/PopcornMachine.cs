using System;

namespace Facade.Classes
{
    public class PopcornMachine
    {
        public void On()
        {
            Console.WriteLine("Popcorn machine is on");
        }

        public void Off()
        {
            Console.WriteLine("Popcorn machine is off");
        }
    }
}