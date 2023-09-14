namespace StatePattern.States
{
    public class Playing : State
    {
        public override string Next()
        {
            // Already playing
            return _mediaPlayer.Error("Already playing...");
        }

        public override string Play()
        {
            // Already playing
            return _mediaPlayer.Error("Already playing...");
        }

        public override string Previous()
        {
            // Already playing
            return _mediaPlayer.Error("Already playing...");
        }

        public override string Stop()
        {
            return _mediaPlayer.Transition(new Stopped());
        }
    }
}
