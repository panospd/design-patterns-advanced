namespace DesignPatterns.UI.Command.Excercise.Commands
{
    public class SetContrastCommand : BaseUndoableCommand
    {
        private float _prevContrast;
        private History _history;
        private float _constrast;

        public SetContrastCommand(float constrast, VideoEditor editor, History history)
            : base(editor, history)
        {
            _history = history;
            _constrast = constrast;
            _prevContrast = editor.Contrast;
        }

        protected override void DoExecute()
        {
            Editor.SetContrast(_constrast);
        }

        public override void Undo()
        {
            Editor.SetContrast(_prevContrast);
        }
    }
}