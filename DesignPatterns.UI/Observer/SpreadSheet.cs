namespace DesignPatterns.UI.Observer
{
    public class SpreadSheet : IObserver
    {
        public void Update()
        {
            System.Console.WriteLine("Updating spreadsheet");
        }
    }
}