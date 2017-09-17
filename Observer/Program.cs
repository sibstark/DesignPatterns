using Observer.Classes;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubject subject = new Subject();
            var third = new Classes.Observer("Third");
            subject.RegisterObserver(new Classes.Observer("First"));
            subject.RegisterObserver(new Classes.Observer("Second"));
            subject.RegisterObserver(third);

            subject.SetState(100, 20, 30);
            subject.RemoveObserver(third);
            subject.SetState(50, 3, 17);

            Console.ReadKey();
        }
    }
}
