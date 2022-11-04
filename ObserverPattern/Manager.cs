using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Manager
    {
        private List<ISubscriber> _subscribers = new List<ISubscriber>();

        public void AddSubscriber(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void RemoveSubscriber(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        public void NotifySubscribers(string state)
        {
            _subscribers.ForEach(sub => sub.Update(state));
        }
    }
}
