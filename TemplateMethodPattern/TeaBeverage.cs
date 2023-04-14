using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class TeaBeverage : CaffeineBeverage
    {
        public override string AddCondiments()
        {
            return "Lemon added...";
        }

        public override string Brew()
        {
            return "Tea added...";
        }
    }
}
