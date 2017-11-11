using System;

namespace FactoryMethod.Classes
{
    public abstract class Pizza
    {
        private string Name { get; }

        public Pizza(string name)
        {
            Name = name;
        }

        public void Cut()
        {
            Console.WriteLine($"{Name} pizza is cuted");
        }

        public void Box()
        {
            Console.WriteLine($"{Name} pizza is boxed");
        }

        public void Bake()
        {
            Console.WriteLine($"{Name} pizza baked");
        }
    }
}
