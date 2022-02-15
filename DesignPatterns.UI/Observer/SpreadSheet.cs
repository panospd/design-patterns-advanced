namespace DesignPatterns.UI.Observer
{
    public class SpreadSheet : IObserver
    {
        public void Update(int value)
        {
            System.Console.WriteLine($"Updating spreadsheet with value {value}");
        }
    }
}