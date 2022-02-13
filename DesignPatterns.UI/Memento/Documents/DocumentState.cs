namespace DesignPatterns.UI.Memento.Documents
{
    public class DocumentState : IDocument
    {
        public string Content { get; init; } = string.Empty;
        public string FontName { get; init; } = string.Empty;
        public int FontSize { get; init; }
    }
}