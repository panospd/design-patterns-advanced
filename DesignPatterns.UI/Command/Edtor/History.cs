namespace DesignPatterns.UI.Command.Edtor
{
    public class History
    {
        private Stack<IUndoableCommand> _commands = new();

        public void Push(IUndoableCommand comand) 
        {
            _commands.Push(comand);
        }

        public IUndoableCommand Pop()
        {
            return _commands.Pop();
        }

        public int Size ()
        {
            return _commands.Count;
        }
    }
}