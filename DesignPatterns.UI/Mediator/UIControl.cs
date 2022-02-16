namespace DesignPatterns.UI.Mediator
{
    public abstract class UIControl
    {
        protected DialogBox Owner;

        protected UIControl(DialogBox owner)
        {
            Owner = owner;
        }
    }
}