namespace DecoratorPattern
{
    public abstract class Cocktail
    {
        public string description = string.Empty;
        public string GetDescription()
        {
            return description;
        }
        public abstract double GetCost();
    }
}