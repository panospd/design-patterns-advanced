namespace DesignPatterns.UI.Strategy.Compressors
{
    public class JpegCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            System.Console.WriteLine($"Compresing {fileName} using jpeg");
        }
    }
}