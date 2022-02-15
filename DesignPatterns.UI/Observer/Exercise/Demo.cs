namespace DesignPatterns.UI.Observer.Exercise
{
    public class Demo
    {
        public void Main()
        {
            var stock1 = new Stock();
            var stock2 = new Stock();
            var stock3 = new Stock();

            var statusBar = new StatusBar();
            var listView = new StockListView();
            statusBar.AddStock(stock1);
            statusBar.AddStock(stock2);
            statusBar.AddStock(stock3);

            listView.AddStock(stock1);
            listView.AddStock(stock2);
            listView.AddStock(stock3);

            stock1.SetValue(6);
            stock2.SetValue(12);
            stock3.SetValue(8);
        }
    }
}