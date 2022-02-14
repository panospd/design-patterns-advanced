namespace DesignPatterns.UI.Iterator.Excercise
{
    public interface Iterator<T>
    {
        bool HasNext();
        T Curent();
        void Next();
    }
}