using CommandPattern.Interfaces;

namespace CommandPattern.Entities
{
    public class LivingRoomLigth : ILigth
    {
        public string Off()
        {
            return "Living room ligth: OFF!";
        }

        public string On()
        {
            return "Living room ligth: ON!";
        }
    }
}
