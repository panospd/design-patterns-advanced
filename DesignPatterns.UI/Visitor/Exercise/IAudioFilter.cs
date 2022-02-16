namespace DesignPatterns.UI.Visitor.Exercise
{
    public interface IAudioFilter
    {
        void ApplyTo(FormatSegment segment);
        void ApplyTo(FactSegment segment);
    }
}