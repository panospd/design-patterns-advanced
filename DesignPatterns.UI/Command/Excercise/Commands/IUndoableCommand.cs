namespace DesignPatterns.UI.Command.Excercise.Commands
{
    public interface IUndoableCommand : ICommand
    {
        void Undo();
    }
}