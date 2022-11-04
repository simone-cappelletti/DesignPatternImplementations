using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Subscribers
{
    public class Subscriber1 : ISubscriber
    {
        public string State { get; set; }

        public void Update(string newState)
        {
            State = $"{this.GetType().Name} has received the new state: {newState}";
        }
    }
}
