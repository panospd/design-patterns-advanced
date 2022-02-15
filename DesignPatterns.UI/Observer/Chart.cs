namespace DesignPatterns.UI.Observer
{
    public class Chart : IObserver
    {
        private readonly DataSource _dataSource;

        public Chart(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            System.Console.WriteLine($"Updating Chart with value {_dataSource.Value}");
        }
    }
}