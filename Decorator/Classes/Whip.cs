namespace Decorator.Classes
{
    public class Whip : CondimentDecorator
    {
        private Beverage Beverage { get; }

        public Whip(Beverage beverage)
            : base(beverage)
        {
            Beverage = beverage;
        }
        public override double Cost()
        {
            return 1.20 + Beverage.Cost();
        }

        public override string GetDescription()
        {
            return $"{Beverage.GetDescription()}, Whip";
        }
    }
}
