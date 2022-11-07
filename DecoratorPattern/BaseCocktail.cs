using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class BaseCocktail : Cocktail
    {
        protected Cocktail cocktail;

        public override double GetCost()
        {
            return this.cocktail.GetCost();
        }
    }
}
