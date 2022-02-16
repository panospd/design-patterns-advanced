namespace DesignPatterns.UI.Mediator
{
    public class ListBox : UIControl
    {
        public string Selection { get; private set; } = string.Empty;
        public void SetSelection(string selection)
        {
            Selection = selection;
            ExecuteHandlers();
        }
    }
}