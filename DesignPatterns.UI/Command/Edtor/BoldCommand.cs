namespace DesignPatterns.UI.Command.Edtor
{
    public class BoldCommand : IUndoableCommand
    {
        private string _prevContent;
        private HtmlDocument _document;
        private History _history;

        public BoldCommand(HtmlDocument document, History history)
        {
            _document = document;
            _history = history;
            _prevContent = _document.Content;
            
        }

        public void Execute()
        {
            _document.MakeBold();
            _history.Push(this);
        }

        public void UnExecute()
        {
            _document.Content = _prevContent;
        }
    }
}