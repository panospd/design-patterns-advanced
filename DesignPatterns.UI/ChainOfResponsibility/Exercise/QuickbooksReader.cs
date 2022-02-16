namespace DesignPatterns.UI.ChainOfResponsibility.Exercise
{
    public class QuickbooksReader : DataReader
    {
        public QuickbooksReader(DataReader? next) : base(next)
        {
        }

        public override void DoRead(string fileName)
        {
            System.Console.WriteLine("Raeding quick books");
        }

        public override string GetFileExtention()
        {
            return ".qbw";
        }
    }
}