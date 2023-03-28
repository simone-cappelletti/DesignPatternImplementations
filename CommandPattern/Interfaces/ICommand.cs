namespace CommandPattern.Interfaces
{
    public interface ICommand
    {
        string Execute();
        string Undo();
    }
}