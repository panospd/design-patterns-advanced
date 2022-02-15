namespace DesignPatterns.UI.Observer
{
    public class DataSource : Subject
    {
        public int Value { get; private set; }
        
        public void SetValue(int value)
        {
            Value = value;
            NotifyObservers(Value);
        }
    }
}