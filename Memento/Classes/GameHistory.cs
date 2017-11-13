using System.Collections.Generic;

namespace Memento.Classes
{
    public class GameHistory
    {
        public Stack<HeroMemento> History {get;} = new Stack<HeroMemento>();
    }
}