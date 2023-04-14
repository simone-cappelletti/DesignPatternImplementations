using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class CoffeBeverage : CaffeineBeverage
    {
        public override string AddCondiments()
        {
            return "Sugar added...";
        }

        public override string Brew()
        {
            return "Cofffee added...";
        }

        public override void Hook()
        {
            //Some other operations

            base.Hook();
        }
    }
}
