namespace DesignPatterns.UI.Strategy.Compressors
{
    public class PngCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            System.Console.WriteLine($"Compresing {fileName} using png");
        }
    }
}