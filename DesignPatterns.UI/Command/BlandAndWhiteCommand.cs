using DesignPatterns.UI.Command.FX;

namespace DesignPatterns.UI.Command
{
    public class BlandAndWhiteCommand : ICommand
    {
        public void Execute()
        {
            System.Console.WriteLine("Applying black and white filter");
        }
    }
}