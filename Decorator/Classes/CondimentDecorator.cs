namespace Decorator.Classes
{
    public abstract class CondimentDecorator : Beverage
    {
        private Beverage Beverage { get; }

        public CondimentDecorator(Beverage beverage)
        {
            Beverage = beverage;
        }
        public override string GetDescription()
        {
            return base.GetDescription();
        }
    }
}
