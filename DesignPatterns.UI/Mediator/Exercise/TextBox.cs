namespace DesignPatterns.UI.Mediator.Exercise
{
    public class TextBox : UIControl
    {
        public string Content { get; private set; } = string.Empty;

        public void SetContent(string content)
        {
            Content = content;
            InvokeHandlers();
        }

        public bool IsEmpty() => string.IsNullOrWhiteSpace(Content);
    }
}