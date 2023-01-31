using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Transports
{
    public class Truck : ITransport
    {
        public string DeliveryStart()
        {
            return $"{DateTime.UtcNow}: Truck off!";
        }
    }
}
