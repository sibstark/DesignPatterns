namespace Command.Classes
{
    public interface ICommand
    {
         void Execute();
         void Undo();
    }
}