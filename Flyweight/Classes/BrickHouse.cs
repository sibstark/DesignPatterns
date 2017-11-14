using System;

namespace Flyweight.Classes
{
    public class BrickHouse : House
    {
        public BrickHouse()
        {
            stages = 5;
        }

        public override void Build(double longitude, double latitude)
        {
            Console.WriteLine("Brick house with 5 stages; coordinates: {0} longitude и {1} latitude",
                latitude, longitude);
        }
    }
}