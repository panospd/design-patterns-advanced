namespace DesignPatterns.UI.Visitor.Exercise
{
    public class NoiseReductionFilter : IAudioFilter
    {
        public void ApplyTo(FormatSegment segment)
        {
            System.Console.WriteLine("Noise reduction for format segment");
        }

        public void ApplyTo(FactSegment segment)
        {
            System.Console.WriteLine("Noise reduction for fact segment");
        }
    }
}