namespace Command.Classes
{
    public class StereoOnCommand : ICommand
    {
        private Stereo Stereo {get;}
        public StereoOnCommand(Stereo stereo)
        {
            Stereo = stereo;
        }
        public void Execute()
        {
            Stereo.SetCd();
            Stereo.SetVolume(5);
            Stereo.On();
        }

        public void Undo()
        {
            Stereo.Off();
        }
    }
}