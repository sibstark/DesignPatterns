namespace Singleton.Classes
{
    public class Singleton
    {
        private static Singleton _instance;
        public string Name {get;set;}
        private Singleton()
        {
            
        }

        public static Singleton Instance => _instance ?? (_instance = new Singleton());
    }
}