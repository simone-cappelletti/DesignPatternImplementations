using FactoryMethodPattern.Transports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Factories
{
    public class TruckFactory : Factory
    {
        public override ITransport CreateTransport()
        {
            return new Truck();
        }
    }
}
