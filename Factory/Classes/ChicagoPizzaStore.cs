using System;

namespace FactoryMethod.Classes
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string pizzaType)
        {
            Pizza pizza;
            switch (pizzaType)
            {
                case "cheez":
                    pizza = new ChicagoCheezPizza("Chicago cheez pizza");
                    break;
                case "Chicago":
                    pizza = new ChicagoPizza("Chicago pizza");
                    break;
                default:
                    throw new InvalidOperationException("Pizza type is not found");
                    break;
            }

            return pizza;
        }
    }
}
