using CommandPattern.Entities;
using CommandPattern.Interfaces;

namespace CommandPattern.Commands
{
    public class LightOffCommand : ICommand
    {
        private ILigth ligth;

        public LightOffCommand(ILigth light)
        {
            this.ligth = light;
        }

        public string Execute()
        {
            return ligth.Off();
        }
    }
}
