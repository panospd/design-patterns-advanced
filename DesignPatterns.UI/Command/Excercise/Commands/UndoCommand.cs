using DesignPatterns.UI.Command.Excercise.Commands;

namespace DesignPatterns.UI.Command.Excercise
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

            _history.Pop().Undo();        
        }
    }
}