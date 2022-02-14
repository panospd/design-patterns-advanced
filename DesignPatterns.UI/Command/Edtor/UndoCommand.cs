namespace DesignPatterns.UI.Command.Edtor
{
    public class UndoCommand : ICommand
    {
        private History _history;

        public UndoCommand(History history)
        {
            _history = history;
        }

        public void Execute()
        {
            if (_history.Size() == 0)
            {
                return;
            }

            var command = _history.Pop();
            command.UnExecute();
        }
    }
}