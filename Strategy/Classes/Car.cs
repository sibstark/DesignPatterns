namespace Strategy.Classes
{
    public class Car
    {
        private int _number;
        public Car(IMove move, int number)
        {
            Movable = move;
            _number = number;
        }

        public IMove Movable { private get; set; }
        public void Move()
        {
            Movable.Move();
        }
    }
}