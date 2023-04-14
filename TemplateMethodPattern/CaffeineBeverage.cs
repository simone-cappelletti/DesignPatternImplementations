using System.Text;

namespace TemplateMethodPattern
{
    public abstract class CaffeineBeverage
    {
        public string PrepareCaffeineBeverage()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(BoilWater());
            sb.AppendLine(Brew());
            sb.AppendLine(PourInCup());
            sb.AppendLine(AddCondiments());

            Hook();

            return sb.ToString();
        }

        public string BoilWater()
        {
            return "Boiling water...";
        }
        public string PourInCup()
        {
            return "Pouring in cup...";
        }

        public abstract string Brew();
        public abstract string AddCondiments();

        public virtual void Hook()
        {

        }
    }
}