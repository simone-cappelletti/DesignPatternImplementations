namespace DecoratorPattern.Decorators
{
    public class GinMalfy : BaseCocktail
    {
        private const double GINMALFY_PRICE = 6;
        public GinMalfy(Cocktail cocktail)
        {
            this.cocktail = cocktail;
        }

        public override double GetCost()
        {
            return this.cocktail.GetCost() + GINMALFY_PRICE;
        }
    }
}
