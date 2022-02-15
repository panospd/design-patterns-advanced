namespace DesignPatterns.UI.Command.Excercise.Commands
{
    public class SetTextCommand : BaseUndoableCommand
    {
        private readonly string _text;
        public SetTextCommand(string text, VideoEditor editor, History history) 
            : base(editor, history)
        {
            _text = text;
        }

        public override void Undo()
        {
            Editor.RemoveText();
        }

        protected override void DoExecute()
        {
            Editor.SetText(_text);
        }
    }
}