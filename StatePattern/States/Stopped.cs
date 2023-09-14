namespace StatePattern.States
{
    public class Stopped : State
    {
        public override string Next()
        {
            return _mediaPlayer.Transition(new Playing());
        }

        public override string Play()
        {
            return _mediaPlayer.Transition(new Playing());
        }

        public override string Previous()
        {
            return _mediaPlayer.Transition(new Playing());
        }

        public override string Stop()
        {
            // Already stopped
            return _mediaPlayer.Error("Already stopped...");
        }
    }
}
