using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorators
{
    public class LemonSoda : BaseCocktail
    {
        private const double LEMONSODA_PRICE = 2;

        public LemonSoda(Cocktail cocktail)
        {
            this.cocktail = cocktail;
        }

        public override double GetCost()
        {
            return this.cocktail.GetCost() + LEMONSODA_PRICE;
        }
    }
}
