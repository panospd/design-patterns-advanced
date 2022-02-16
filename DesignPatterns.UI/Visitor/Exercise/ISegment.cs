namespace DesignPatterns.UI.Visitor.Exercise
{
    public interface ISegment
    {
        void ApplyFilter(IAudioFilter filter);
    }
}