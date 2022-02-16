namespace DesignPatterns.UI.Visitor
{
    public class AnchorNode : IHtmlNode
    {
        public void Execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}