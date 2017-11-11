namespace AbstractFactory.Classes
{
    public interface IPizzaIngredientFactory
    {
         Dough CreateDough();
         Sauce CreateSauce();
         Cheese CreateCheese();
         Veggies[] CreateVeggies();
         Pepperoni CreatePepperoni();
         Clams CreateClams();
    }
}