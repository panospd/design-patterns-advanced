namespace DesignPatterns.UI.Command.Excercise.Commands
{
    public class History
    {
        private Stack<IUndoableCommand> _commands = new();

        public int Size () => _commands.Count;

        public void Push(IUndoableCommand command)
        {
            _commands.Append(command);
        }

        public IUndoableCommand Pop() => _commands.Pop();
    }
}