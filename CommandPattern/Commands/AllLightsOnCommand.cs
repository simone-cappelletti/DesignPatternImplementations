using CommandPattern.Interfaces;
using System.Text;

namespace CommandPattern.Commands
{
    public class AllLightsOnCommand : ICommand
    {
        IList<ICommand> commands;

        public AllLightsOnCommand(List<ICommand> commands)
        {
            this.commands = commands;
        }

        public string Execute()
        {
            var stringbuilder = new StringBuilder();

            foreach (var command in commands)
            {
                stringbuilder.Append(command.Execute());
            }

            return stringbuilder.ToString();
        }

        public string Undo()
        {
            var stringbuilder = new StringBuilder();

            foreach (var command in commands.Reverse())
            {
                stringbuilder.Append(command.Undo());
            }

            return stringbuilder.ToString();
        }
    }
}
