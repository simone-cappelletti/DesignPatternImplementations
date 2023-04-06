using FacadePattern.Entities;
using System.Text;

namespace FacadePattern
{
    public class HomeTheater : IHomeTheater
    {
        private Amplifier _amplifier;
        private Tuner _tuner;
        private StreamingPlayer _streamingPlayer;
        private Projector _projector;
        private TheaterLights _theaterLights;
        private Screen _screen;
        private PopcornPopper _popcornPopper;

        public HomeTheater(
            Amplifier amplifier,
            Tuner tuner,
            StreamingPlayer streamingPlayer,
            Projector projector,
            TheaterLights theaterLights,
            Screen screen,
            PopcornPopper popcornPopper)
        {
            _amplifier = amplifier;
            _tuner = tuner;
            _streamingPlayer = streamingPlayer;
            _projector = projector;
            _theaterLights = theaterLights;
            _screen = screen;
            _popcornPopper = popcornPopper;
        }

        public string TurnOfHomeTheater()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Popcorn popper turned off.");
            _popcornPopper.Off();

            sb.AppendLine("Home theater ligths turned on.");
            _theaterLights.On();

            sb.AppendLine("The screen is going up...");
            _screen.Up();

            sb.AppendLine("Projector turned off.");
            _projector.Off();

            sb.AppendLine("Amplifier turned off.");
            _amplifier.Off();

            sb.Append($"Streaming player turned off.");
            _streamingPlayer.Off();

            return sb.ToString();
        }

        public string TurnOnHomeTheater(string movie)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Popcorn popper turned on... popping ...");
            _popcornPopper.On();
            _popcornPopper.Pop();

            sb.AppendLine("Home theater ligths turned off.");
            _theaterLights.Off();

            sb.AppendLine("The screen is coming down...");
            _screen.Down();

            sb.AppendLine("Projector turned on and set to wide screen mode.");
            _projector.On();
            _projector.WideScreenMode();

            sb.AppendLine("Amplifier turned on.");
            _amplifier.On();
            _amplifier.SetStreamingPlayer();
            _amplifier.SetSurroundSound();
            _amplifier.SetVolume(5);

            sb.AppendLine($"Streaming player turned on.");
            sb.Append($"Starting {movie}, enjoy!");
            _streamingPlayer.On();
            _streamingPlayer.Play("movie");

            return sb.ToString();
        }
    }
}