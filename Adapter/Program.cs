using System;
using Adapter.Classes;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IDuck duck = new Duck();
            duck.Fly();
            duck.Quack();
            ITurkey turkey = new Turkey();
            turkey.Fly();
            turkey.Quobble();

            TestDucks(new IDuck[]{duck, new TurkeyDuckAdapter(turkey)});
        }

        private static void TestDucks(IDuck[] ducks)
        {
            
            foreach (var item in ducks)
            {
                item.Fly();
                item.Quack();
            }
        }
    }
}
