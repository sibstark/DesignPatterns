namespace Adapter.Classes
{
    public class TurkeyDuckAdapter : IDuck
    {
        private ITurkey Turkey {get;}
        public TurkeyDuckAdapter(ITurkey turkey)
        {
            Turkey = turkey;
        }
        public void Fly()
        {
            Turkey.Fly();
        }

        public void Quack()
        {
            Turkey.Quobble();
        }
    }
}