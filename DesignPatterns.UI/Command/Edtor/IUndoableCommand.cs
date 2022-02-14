namespace DesignPatterns.UI.Command.Edtor
{
    public interface IUndoableCommand : ICommand
    {
        void UnExecute();
    }
}