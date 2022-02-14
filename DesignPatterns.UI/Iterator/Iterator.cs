namespace DesignPatterns.UI.Iterator
{
    public interface Iterator<T>
    {
        bool HasNext();
        T Current();
        void Next();
    }
}