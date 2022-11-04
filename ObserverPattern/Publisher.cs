namespace ObserverPattern
{
    public class Publisher
    {
        public Manager Manager { get; set; } = new Manager();

        private string state;

        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;

                Manager.NotifySubscribers(state);
            }
        }
    }
}