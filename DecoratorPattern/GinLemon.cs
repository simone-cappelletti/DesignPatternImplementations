using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class GinLemon : Cocktail
    {
        private const double BASE_PRICE = 10;

        public GinLemon()
        {
            this.description = "Gin Lemon";
        }
        public override double GetCost()
        {
            return BASE_PRICE;
        }
    }
}
