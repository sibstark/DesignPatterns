namespace FactoryMethod.Classes
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string pizzaType)
        {
            var pizza = CreatePizza(pizzaType);
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(string pizzaType);
    }
}
