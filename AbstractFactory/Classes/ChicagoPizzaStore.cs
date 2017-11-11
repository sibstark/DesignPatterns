using System;

namespace AbstractFactory.Classes
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string pizzaType)
        {
            var ingredientFactory = new ChicagoPizzaIngredientFactory();
            Pizza pizza;
            switch(pizzaType)
            {
                case "cheese":
                    pizza = new SheesePizza("Chicago Cheese Pizza", ingredientFactory);
                    break;
                case "clam":
                    pizza = new ClamPizza("Chicago Clam pizza", ingredientFactory);
                    break;
                default:
                    throw new InvalidOperationException("Pizza type is not found");
                    break;
            }

            return pizza;
        }
    }
}