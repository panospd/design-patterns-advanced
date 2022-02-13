using DesignPatterns.UI.State.Tools;

namespace DesignPatterns.UI.State
{
    public class Canvas
	{
        public ITool Tool { get; private set; }

        public Canvas(ITool tool)
        {
            Tool = tool;
        }

        public void SetTool(ITool tool)
        {
            Tool = tool;
        }

        public void MouseDown()
		{
            Tool.MouseDown();
		}

		public void MouseUp()
		{
            Tool.MouseUp();
		}
	}
}