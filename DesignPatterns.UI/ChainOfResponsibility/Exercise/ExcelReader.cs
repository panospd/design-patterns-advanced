namespace DesignPatterns.UI.ChainOfResponsibility.Exercise
{
    public class ExcelReader : DataReader
    {
        public ExcelReader(DataReader? next) 
            : base(next)
        {
        }

        public override void DoRead(string fileName)
        {
            System.Console.WriteLine("Reading excel file");
        }

        public override string GetFileExtention()
        {
            return ".xls";
        }
    }
}