namespace DesignPatterns.UI.Visitor.Exercise
{
    public class WavFile 
    {
        private List<ISegment> _segments = new List<ISegment>();

        public static WavFile Read(string fileName)
        {
            var file = new WavFile();

            file._segments.Add(new FormatSegment());
            file._segments.Add(new FactSegment());
            file._segments.Add(new FactSegment());
            file._segments.Add(new FactSegment());

            return file;
        }

        public void ApplyFilter(IAudioFilter filter)
        {
            _segments.ForEach(s => s.ApplyFilter(filter));
        }
    }
}