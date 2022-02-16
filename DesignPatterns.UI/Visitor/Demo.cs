namespace DesignPatterns.UI.Visitor
{
    public class Demo
    {
        public void Main()
        {
            var document = new HtmlDocument();

            document.Add(new HeadingNode());
            document.Add(new AnchorNode());

            document.Execute(new HighLightOperation());
        }
    }
}