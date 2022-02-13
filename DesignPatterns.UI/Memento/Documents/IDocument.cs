namespace DesignPatterns.UI.Memento.Documents
{
    public interface IDocument
    {
        string Content { get; }
        string FontName { get; }
        int FontSize { get; }
    }
}