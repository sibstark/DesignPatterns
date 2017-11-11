namespace AbstractFactory.Classes
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new ChicagoSheese();
        }

        public Clams CreateClams()
        {
            return new FreshChicagoClams();
        }

        public Dough CreateDough()
        {
            return new ThinCrustChicagoDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedChicagoPepperoni();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraChicagoSause();
        }

        public Veggies[] CreateVeggies()
        {
            return new Veggies [] {new ChicagoOnion(), new ChicagoGarlic(), new ChicagoMushroom(), new ChicagoRedPepper()};
        }
    }
}