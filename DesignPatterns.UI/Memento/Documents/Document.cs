using DesignPatterns.UI.Memento.Documents.Actions;

namespace DesignPatterns.UI.Memento.Documents
{
    public class Document : IDocument
    {
        public string Content { get; private set; } = string.Empty;
        public string FontName { get; private set; } = string.Empty;
        public int FontSize { get; private set; }

        public void Restore(DocumentState state)
        {
            Content = state.Content;
            FontName = state.FontName;
            FontSize = state.FontSize;
        }
        
        public DocumentState CreateState()
        {
            return new DocumentState
            {
                Content = Content,
                FontName = FontName,
                FontSize = FontSize
            }; 
        }

        public void Update<T>(BaseDocumentAction<T> action)
        {
            switch (action)
            {
                case SetContentAction act:
                    Content = act.Payload;
                    break;
                case SetFontNameAction act:
                    FontName = act.Payload;
                    break;
                case SetFontSizeAction act:
                    FontSize = act.Payload;
                    break;
                default:
                    throw new NotSupportedException($"Not supported action {action.GetType()}");
            }
        }
    }
}