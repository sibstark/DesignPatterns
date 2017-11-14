using System;

namespace Flyweight.Classes
{
    public class PanelHouse : House
    {
        public PanelHouse()
        {
            stages = 16;
        }

        public override void Build(double longitude, double latitude)
        {
            Console.WriteLine("Panel house with 16 stages; coordinates: {0} longitude и {1} latitude",
                latitude, longitude);
        }
    }
}