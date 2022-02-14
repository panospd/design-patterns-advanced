using DesignPatterns.UI.Strategy.Compressors;
using DesignPatterns.UI.Strategy.Filters;

namespace DesignPatterns.UI.Strategy
{
    public class ImageStorage
    {
        public void Store(string fileName, ICompressor compressor, IFilter filter)
        {
            compressor.Compress(fileName);
            filter.Apply(fileName);
        }
    }
}