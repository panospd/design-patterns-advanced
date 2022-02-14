namespace DesignPatterns.UI.Strategy.Filters
{
    public class BlackAndWhiteFilter : IFilter
    {
        public void Apply(string fileName)
        {
            System.Console.WriteLine($"Applying black and white filter to {fileName}");
        }
    }
}