using FactoryMethod.Classes;
using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var nyPizzaStore = new NYPizzaStore();
            var chicagoPizzaStore = new ChicagoPizzaStore();

            var chicagoPizza = chicagoPizzaStore.OrderPizza("Chicago");
            var chicagoCheezPizza = chicagoPizzaStore.OrderPizza("cheez");

            var nyPizza = nyPizzaStore.OrderPizza("cheez");
            var nyCheezPizza = nyPizzaStore.OrderPizza("NY");

            Console.ReadKey();
        }
    }
}
