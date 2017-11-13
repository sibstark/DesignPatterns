namespace Bridge.Classes
{
    public abstract class Programmer
    {

        protected ILanguage _language;
        public ILanguage Language
        {
            set { _language = value; }
        }

        public Programmer(ILanguage lang)
        {
            _language = lang;
        }

        public virtual void DoWork()
        {
            _language.Build();
            _language.Execute();
        }
        public abstract void EarnMoney();
    }
}
