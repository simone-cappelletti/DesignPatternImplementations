using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorators
{
    public class GinMare : BaseCocktail
    {
        private const double GINMARE_PRICE = 5;
        public GinMare (Cocktail cocktail)
        {
            this.cocktail = cocktail;
        }

        public override double GetCost()
        {
            return this.cocktail.GetCost() + GINMARE_PRICE;
        }
    }
}
