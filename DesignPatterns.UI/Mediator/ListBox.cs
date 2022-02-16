namespace DesignPatterns.UI.Mediator
{
    public class ListBox : UIControl
    {
        public ListBox(DialogBox owner)
            : base(owner) { }

        public string Selection { get; private set; } = string.Empty;
        public void SetSelection(string selection)
        {
            Selection = selection;
            Owner.Changed(this);
        }
    }
}