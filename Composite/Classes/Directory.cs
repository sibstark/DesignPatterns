using System;
using System.Collections.Generic;

namespace Composite.Classes
{
    public class Directory : Component
    {
        private List<Component> components = new List<Component>();

        public Directory(string name)
            : base(name)
        {
        }

        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }

        public override void Print()
        {
            Console.WriteLine("Module " + name);
            Console.WriteLine("Submodules:");
            for (int i = 0; i < components.Count; i++)
            {
                components[i].Print();
            }
        }
    }
}
