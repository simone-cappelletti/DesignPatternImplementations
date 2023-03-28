using CommandPattern.Entities;
using CommandPattern.Interfaces;

namespace CommandPattern.Commands
{
    public class LightOnCommand : ICommand
    {
        private ILigth ligth;

        public LightOnCommand(ILigth light)
        {
            this.ligth = light;
        }

        public string Execute()
        {
            return ligth.On();
        }
    }
}
