namespace DesignPatterns.UI.Visitor
{
    public class HighLightOperation : IOperation
    {
        public void Apply(AnchorNode anchorNode)
        {
            System.Console.WriteLine("HIghlight achor");
        }

        public void Apply(HeadingNode headingNode)
        {
            System.Console.WriteLine("Highlight heading");
        }
    }
}