namespace Decorator.Classes
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            _description = "House Blend Coffe";
        }

        public override double Cost()
        {
            return .89;
        }
    }
}
