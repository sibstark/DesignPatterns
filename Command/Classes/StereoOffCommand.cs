namespace Command.Classes
{
    public class StereoOffCommand : ICommand
    {
        private Stereo Stereo {get;}
        public StereoOffCommand(Stereo stereo)
        {
            Stereo = stereo;
        }
        public void Execute()
        {
            Stereo.Off();
        }

        public void Undo()
        {
            Stereo.On();
        }
    }
}