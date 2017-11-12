namespace Command.Classes
{
    public class RemoteControl
    {
        private ICommand[] _onCommands;
        private ICommand _undoCommand;
        private ICommand[] _offCommands;
        public RemoteControl()
        {
            _onCommands = new ICommand[3];
            _offCommands = new ICommand[3];
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnPush(int slot)
        {
            _onCommands[slot].Execute();
            _undoCommand = _onCommands[slot];
        }

        public void OffPush(int slot)
        {
            _offCommands[slot].Execute();
            _undoCommand = _offCommands[slot];
        }

        public void UndoPush()
        {
            _undoCommand.Undo();
        }
    }
}