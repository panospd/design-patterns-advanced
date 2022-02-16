namespace DesignPatterns.UI.Mediator
{
    public class Button : UIControl
    {
        public Button(DialogBox owner)
            : base(owner) { }

        public bool IsEnabled { get; private set; }

        public void SetEnabled(bool enabled)
        {
            IsEnabled = enabled;
        }
    }
}