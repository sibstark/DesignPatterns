using System;

namespace Command.Classes
{
    public class Stereo
    {
        public void SetVolume(int volume)
        {
            Console.WriteLine($"Volume is seted on {volume}");
        }

        public void SetCd()
        {
            Console.WriteLine("Cd is seted");
        }

        public void On()
        {
            Console.WriteLine("Stereo is on");
        }

        public void Off()
        {
            Console.WriteLine("Stereo is off");
        }
    }
}