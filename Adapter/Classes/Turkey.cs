using System;

namespace Adapter.Classes
{
    public class Turkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("Iam flying on short range");
        }

        public void Quobble()
        {
            Console.WriteLine("Quobble, Quobble");
        }
    }
}