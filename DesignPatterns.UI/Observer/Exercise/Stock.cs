namespace DesignPatterns.UI.Observer.Exercise
{
    public class Stock
    {
        private List<IObserver> _observers = new();

        public int Value { get; private set; }

        public void SetValue(int value) 
        {
            Value = value;
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.PriceChanged();
            }
        }
    }
}