using System;

namespace AbstractFactory.Classes
{
    public class SheesePizza : Pizza
    {
        public SheesePizza(string name, IPizzaIngredientFactory ingredientFactory) : base(name, ingredientFactory)
        {
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = IngredientFactory.CreateDough();
            Sauce = IngredientFactory.CreateSauce();
            Cheese = IngredientFactory.CreateCheese();
        }
    }
}