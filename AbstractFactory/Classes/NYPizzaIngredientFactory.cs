namespace AbstractFactory.Classes
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new ReggianoSheese();
        }

        public Clams CreateClams()
        {
            return new FreshClams();
        }

        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSause();
        }

        public Veggies[] CreateVeggies()
        {
            return new Veggies [] {new Onion(), new Garlic(), new Mushroom(), new RedPepper()};
        }
    }
}