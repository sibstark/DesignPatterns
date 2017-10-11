namespace Decorator.Classes
{
    public abstract class Beverage
    {
        protected string _description = "unkown";

        public virtual string GetDescription()
        {
            return _description;
        }
        
        public abstract double Cost();
    }
}
