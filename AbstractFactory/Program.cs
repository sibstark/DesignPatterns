using System;
using AbstractFactory.Classes;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var nyPizzaStore = new NYPizzaStore();
            var chicagoPizzaStore = new ChicagoPizzaStore();

            var chicagoPizza = chicagoPizzaStore.OrderPizza("cheese");
            var chicagoCheezPizza = chicagoPizzaStore.OrderPizza("clam");

            var nyPizza = nyPizzaStore.OrderPizza("cheese");
            var nyCheezPizza = nyPizzaStore.OrderPizza("clam");

            Console.ReadKey();
        }
    }
}
