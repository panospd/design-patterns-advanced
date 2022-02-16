namespace DesignPatterns.UI.Mediator.Exercise
{
    public class CheckBox : UIControl
    {
        public bool IsChecked { get; private set; }

        public void Check(bool isChecked)
        {
            IsChecked = isChecked;
            InvokeHandlers();
        }
    }
}