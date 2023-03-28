using CommandPattern.Interfaces;

namespace CommandPattern
{
    public class HouseRemoteController
    {
        private ICommand command;
        private Stack<ICommand> commandQueue = new Stack<ICommand>();

        public HouseRemoteController()
        {

        }

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public string ExecuteCommand()
        {
            commandQueue.Push(command);

            return command.Execute();
        }

        public string UndoCommand()
        {
            ICommand command;

            if (commandQueue.TryPop(out command))
                return command.Undo();
            else
                return "No undo action available!";
        }
    }
}
