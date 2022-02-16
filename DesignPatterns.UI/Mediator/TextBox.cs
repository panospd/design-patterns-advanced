namespace DesignPatterns.UI.Mediator
{
    public class TextBox : UIControl
    {
        public TextBox(DialogBox owner)
            : base(owner) { }

        public string Content { get; private set; } = string.Empty;

        public void SetContent(string content)
        {
            Content = content;
            Owner.Changed(this);
        }
    }
}