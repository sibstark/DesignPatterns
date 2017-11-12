namespace Command.Classes
{
    public class LightOnCommand : ICommand
    {
        private Light Light {get;}
        public LightOnCommand(Light light)
        {
            Light = light;
        }
        public void Execute()
        {
            Light.On();
        }

        public void Undo()
        {
            Light.Off();
        }
    }
}