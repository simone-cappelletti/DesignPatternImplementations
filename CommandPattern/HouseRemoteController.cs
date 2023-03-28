using CommandPattern.Interfaces;

namespace CommandPattern
{
    public class HouseRemoteController
    {
        private ICommand command;

        public HouseRemoteController()
        {

        }

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public string ExecuteCommand()
        {
            return command.Execute();
        }

        public string UndoCommand()
        {
            if (command != null)
                return command.Undo();
            else
                return "No undo action available!";
        }
    }
}
