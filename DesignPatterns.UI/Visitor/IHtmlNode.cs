namespace DesignPatterns.UI.Visitor
{
    public interface IHtmlNode
    {
         void Execute(IOperation operation);
    }
}