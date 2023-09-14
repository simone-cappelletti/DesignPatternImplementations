namespace StatePattern.States
{
    public class Ready : State
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
            return _mediaPlayer.Transition(new Stopped());
        }
    }
}
