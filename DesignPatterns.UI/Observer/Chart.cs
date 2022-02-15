namespace DesignPatterns.UI.Observer
{
    public class Chart : IObserver
    {
        public void Update()
        {
            System.Console.WriteLine("Updating Chart");
        }
    }
}