namespace Decorator.Classes
{
    public class Mocha : CondimentDecorator
    {
        private Beverage Beverage { get; }

        public Mocha(Beverage beverage)
            : base(beverage)
        {
            Beverage = beverage;
        }

        public override double Cost()
        {
            return .20 + Beverage.Cost();
        }

        public override string GetDescription()
        {
            return $"{Beverage.GetDescription()}, Mocha";
        }
    }
}
