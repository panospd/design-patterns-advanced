namespace DesignPatterns.UI.Command.Edtor
{
    public class HtmlDocument
    {
        public string Content { get; set; } = string.Empty;

        public void MakeBold()
        {
            Content = "<b>" + Content + "</b>";
        }
    }
}