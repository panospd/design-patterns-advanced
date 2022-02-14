namespace DesignPatterns.UI.TemplateMethod.Excercise
{
    public abstract class BaseWindow
    {
        public void Close()
        {
            OnBeforeClose();
            System.Console.WriteLine("Removing the window from the screen");
            OnAfterClose();
        }

        protected virtual void OnBeforeClose()
        {
        }

        protected virtual void OnAfterClose()
        {
        }
    }
}