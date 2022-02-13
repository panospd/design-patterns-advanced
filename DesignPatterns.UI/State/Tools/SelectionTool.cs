namespace DesignPatterns.UI.State.Tools
{
    public class SelectionTool : ITool
    {
        public void MouseDown()
        {
            System.Console.WriteLine("Selection icon");
        }

        public void MouseUp()
        {
            System.Console.WriteLine("Draw dashed rectangle");
        }
    }
}