namespace DesignPatterns.UI.Observer
{
    public class SpreadSheet : IObserver
    {
        private readonly DataSource _dataSource;

        public SpreadSheet(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            System.Console.WriteLine($"Updating spreadsheet with value {_dataSource.Value}");
        }
    }
}