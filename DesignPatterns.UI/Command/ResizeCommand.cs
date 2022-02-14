using DesignPatterns.UI.Command.FX;

namespace DesignPatterns.UI.Command
{
    public class ResizeCommand : ICommand
    {
        public void Execute()
        {
            System.Console.WriteLine("Resizing");
        }
    }
}