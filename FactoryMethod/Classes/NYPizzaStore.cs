using System;

namespace FactoryMethod.Classes
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string pizzaType)
        {
            Pizza pizza;
            switch(pizzaType)
            {
                case "cheez":
                    pizza = new NYCheezPizza("NY cheez pizza");
                    break;
                case "NY":
                    pizza = new NYPizza("NY pizza");
                    break;
                default:
                    throw new InvalidOperationException("Pizza type is not found");
                    break;
            }

            return pizza;
        }
    }
}
