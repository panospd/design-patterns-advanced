namespace DesignPatterns.UI.Command.Excercise.Commands
{
    public abstract class BaseUndoableCommand : IUndoableCommand
    {
        protected VideoEditor Editor;
        protected History History;

        protected BaseUndoableCommand(VideoEditor editor, History history)
        {
            History = history;
            Editor = editor;
        }

        public void Execute()
        {
            DoExecute();
            History.Push(this);
        }

        protected abstract void DoExecute();
        public abstract void Undo();
    }
}