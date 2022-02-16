namespace DesignPatterns.UI.Mediator
{
    public class TextBox : UIControl
    {
        public string Content { get; private set; } = string.Empty;

        public void SetContent(string content)
        {
            Content = content;
            ExecuteHandlers();
        }
    }
}