using StatePattern.States;

namespace StatePattern
{
    public class MediaPlayer
    {
        public State State { get; set; }

        public MediaPlayer()
        {
            State = new Ready();
            State.SetContext(this);
        }

        public string Transition(State state)
        {
            var stateMessage = $"Transitioning from {State.GetType()} to {state.GetType()}";

            State = state;

            state.SetContext(this);

            return stateMessage;
        }

        public string Error(string message)
        {
            return message;
        }

        public string Play()
        {
            return State.Play();
        }
        public string Stop()
        {
            return State.Stop();
        }
        public string Next()
        {
            return State.Next();
        }
        public string Previous()
        {
            return State.Previous();
        }
    }
}