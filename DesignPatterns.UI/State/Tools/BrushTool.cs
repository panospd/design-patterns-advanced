namespace DesignPatterns.UI.State.Tools
{
    public class BrushTool : ITool
    {
        public void MouseDown()
        {
            System.Console.WriteLine("Brush icon");
        }

        public void MouseUp()
        {
            System.Console.WriteLine("Draw a line");
        }
    }

    public class EraserTool : ITool
    {
        public void MouseDown()
        {
            System.Console.WriteLine("Eraser icon");
        }

        public void MouseUp()
        {
            System.Console.WriteLine("Erase something");
        }
    }
}