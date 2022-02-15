namespace DesignPatterns.UI.Observer
{
    public class Demo
    {
        public void Main()
        {
            var dataSource = new DataSource();
            var sheet1 = new SpreadSheet();
            var sheet2 = new SpreadSheet();
            var chart = new Chart();

            dataSource.AddObserver(sheet1);
            dataSource.AddObserver(sheet2);
            dataSource.AddObserver(chart);
            
            dataSource.SetValue(5);
        }
    }
}