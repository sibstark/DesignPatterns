namespace Facade.Classes
{
    public class HomeTheaterFacade
    {
        private PopcornMachine PopcornMachine { get; }
        private Tuner Tuner { get; }
        private DvdPlayer DvdPlayer { get; }
        private Projector Projector { get; }
        private Screen Screen { get; }
        public HomeTheaterFacade(PopcornMachine popcornMachine, Tuner tuner, DvdPlayer dvdPlayer, Projector projector, Screen screen)
        {
            PopcornMachine = popcornMachine;
            Tuner = tuner;
            DvdPlayer = dvdPlayer;
            Projector = projector;
            Screen = screen;
        }

        public void WatchMovie()
        {
            PopcornMachine.On();
            Tuner.On();
            DvdPlayer.On();
            Projector.On();
            Screen.On();
        }

        public void EndMovie()
        {
            PopcornMachine.Off();
            Tuner.Off();
            DvdPlayer.Off();
            Projector.Off();
            Screen.Off();
        }
    }
}