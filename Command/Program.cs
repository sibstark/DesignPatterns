using System;
using Command.Classes;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var remoteControl = new RemoteControl();
            var light = new Light();
            var stereo = new Stereo();
            remoteControl.SetCommand(0, new LightOnCommand(light), new LightOffCommand(light));
            remoteControl.SetCommand(1, new StereoOnCommand(stereo), new StereoOffCommand(stereo));

            remoteControl.OnPush(0);
            remoteControl.OffPush(0);
            
            remoteControl.OnPush(1);
            remoteControl.OffPush(1);
            remoteControl.UndoPush();

            Console.ReadKey();
        }
    }
}
