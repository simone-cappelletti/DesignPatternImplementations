using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorators
{
    public class VodkaSky : BaseCocktail
    {
        private const double VODKASKY_PRICE = 5;

        public VodkaSky(Cocktail cocktail)
        {
            this.cocktail = cocktail;
        }

        public override double GetCost()
        {
            return this.cocktail.GetCost() + VODKASKY_PRICE;
        }
    }
}
