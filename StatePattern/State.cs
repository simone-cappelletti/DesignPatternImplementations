namespace StatePattern
{
    public abstract class State
    {
        protected MediaPlayer _mediaPlayer;

        public abstract string Play();
        public abstract string Stop();
        public abstract string Next();
        public abstract string Previous();

        public void SetContext(MediaPlayer mediaPlayer)
        {
            _mediaPlayer = mediaPlayer;
        }
    }
}
