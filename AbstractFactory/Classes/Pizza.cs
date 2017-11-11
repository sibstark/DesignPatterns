using System;

namespace AbstractFactory.Classes
{
    public abstract class Pizza
    {
        public string Name { get; }
        protected Dough Dough { get; set; }
        protected Sauce Sauce { get; set; }
        protected Cheese Cheese { get; set; }
        protected Veggies[] Veggies { get; set; }
        protected Pepperoni Pepperoni { get; set; }
        protected Clams Clams { get; set; }
        protected IPizzaIngredientFactory IngredientFactory {get;}

        public Pizza(string name, IPizzaIngredientFactory ingredientFactory)
        {
            Name = name;       
            IngredientFactory = ingredientFactory;     
        }

        public abstract void Prepare();

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
            Console.WriteLine($"{Name} pizza is baked");
        }
    }
}