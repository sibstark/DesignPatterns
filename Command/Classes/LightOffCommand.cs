namespace Command.Classes
{
    public class LightOffCommand : ICommand
    {
        private Light Light {get;}
        public LightOffCommand(Light light)
        {
            Light = light;
        }
        public void Execute()
        {
            Light.Off();
        }

        public void Undo()
        {
            Light.On();
        }
    }
}