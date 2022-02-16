namespace DesignPatterns.UI.ChainOfResponsibility.Exercise
{
    public class DataReaderFactory
    {
        public static DataReader GetDataReaderChain()
        {
            var excelReader = new ExcelReader(null);
            var numbersReader = new NumbersReader(excelReader);
            var quickbooksReader = new QuickbooksReader(numbersReader);

            return quickbooksReader;
        }
    }
}