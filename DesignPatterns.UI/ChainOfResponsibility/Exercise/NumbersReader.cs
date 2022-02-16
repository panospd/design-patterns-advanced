namespace DesignPatterns.UI.ChainOfResponsibility.Exercise
{
    public class NumbersReader : DataReader
    {
        public NumbersReader(DataReader? next) : base(next)
        {
        }

        public override void DoRead(string fileName)
        {
            System.Console.WriteLine("Reading numbers");
        }

        public override string GetFileExtention()
        {
            return ".numbers";
        }
    }
}