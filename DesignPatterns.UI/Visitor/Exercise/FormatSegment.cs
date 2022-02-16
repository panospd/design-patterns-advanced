namespace DesignPatterns.UI.Visitor.Exercise
{
    public class FormatSegment : ISegment
    {
        public void ApplyFilter(IAudioFilter filter)
        {
            filter.ApplyTo(this);
        }
    }
}