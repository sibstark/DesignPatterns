using System;

namespace Facade.Classes
{
    public class DvdPlayer
    {
        public void On()
        {
            Console.WriteLine("DvdPlayer is on");
        }

        public void Off()
        {
            Console.WriteLine("DvdPlayer is off");
        }
    }
}