namespace DesignPatterns.UI.TemplateMethod.Excercise
{
    public class ChatWindow : BaseWindow
    {
        protected override void OnBeforeClose()
        {
            System.Console.WriteLine("Do something before close");
        }

        protected override void OnAfterClose()
        {
            System.Console.WriteLine("Do something after close");
        }
    }
}