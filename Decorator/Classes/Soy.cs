namespace Decorator.Classes
{
    public class Soy : CondimentDecorator
    {
        private Beverage Beverage { get; }
        public Soy(Beverage beverage)
            : base(beverage)
        {
            Beverage = beverage;
        }
        public override double Cost()
        {
            return 1.70 + Beverage.Cost();
        }

        public override string GetDescription()
        {
            return $"{Beverage.GetDescription()}, Soy";
        }
    }
}
