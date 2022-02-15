namespace DesignPatterns.UI.Observer
{
    public class Chart : IObserver
    {
        public void Update(int value)
        {
            System.Console.WriteLine($"Updating Chart with value {value}");
        }
    }
}