using System;

namespace AbstractFactory.Classes
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string pizzaType)
        {
            var ingredientFactory = new NYPizzaIngredientFactory();
            Pizza pizza;
            switch(pizzaType)
            {
                case "cheese":
                    pizza = new SheesePizza("NY Cheese Pizza", ingredientFactory);
                    break;
                case "clam":
                    pizza = new ClamPizza("NY Clam pizza", ingredientFactory);
                    break;
                default:
                    throw new InvalidOperationException("Pizza type is not found");
                    break;
            }

            return pizza;
        }
    }
}