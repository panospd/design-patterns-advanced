namespace DesignPatterns.UI.Visitor
{
    public interface IOperation
    {
        void Apply(HeadingNode headingNode);
        void Apply(AnchorNode anchorNode);
    }
}