namespace DesignPatterns.UI.Visitor.Exercise
{
    public class FactSegment : ISegment
    {
        public void ApplyFilter(IAudioFilter filter)
        {
            filter.ApplyTo(this);
        }
    }
}