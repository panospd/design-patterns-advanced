namespace DesignPatterns.UI.ChainOfResponsibility.Exercise
{
    public class Demo
    {
        public void Main()
        {
            var reader = DataReaderFactory.GetDataReaderChain();

            reader.Read("panos.xls");
        }
    }
}