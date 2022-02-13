namespace DesignPatterns.UI.Memento.Documents.Actions
{
    public class BaseDocumentAction<T>
    {
        public T Payload { get; }
        public BaseDocumentAction(T payload)
        {
            Payload = payload;
        }
    }

    public class SetContentAction : BaseDocumentAction<string>
    {
        public SetContentAction(string payload)
            : base(payload) { }
    }

    public class SetFontNameAction : BaseDocumentAction<string>
    {
        public SetFontNameAction(string payload)
            : base(payload) { }
    }

    public class SetFontSizeAction : BaseDocumentAction<int>
    {
        public SetFontSizeAction(int payload) 
            : base(payload) { }
    }
}