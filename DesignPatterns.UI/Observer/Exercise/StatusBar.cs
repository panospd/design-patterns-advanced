namespace DesignPatterns.UI.Observer.Exercise
{
    public class StatusBar : IObserver
    {
        private List<Stock> _stocks = new();

        public void AddStock(Stock stock)
        {
            _stocks.Add(stock);
            stock.AddObserver(this);
        }

        public void PriceChanged()
        {
            System.Console.WriteLine("Refreshing Status bar");
        }
    }
}