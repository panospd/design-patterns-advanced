namespace DesignPatterns.UI.Mediator.Exercise
{
    public class Button : UIControl
    {
        public bool Enabled { get; private set; }

        public void SetEnabled(bool enabled)
        {
            Enabled = enabled;
            InvokeHandlers();
        }
    }
}