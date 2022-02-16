namespace DesignPatterns.UI.Mediator
{
    public class Button : UIControl
    {
        public bool IsEnabled { get; private set; }

        public void SetEnabled(bool enabled)
        {
            IsEnabled = enabled;
            ExecuteHandlers();
        }
    }
}