using CommandPattern.Interfaces;

namespace CommandPattern.Entities
{
    public class KitchenLigth : ILigth
    {
        public string Off()
        {
            return "Kitchen ligth: OFF!";
        }

        public string On()
        {
            return "Kitchen ligth: ON!";
        }
    }
}
