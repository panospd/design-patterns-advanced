namespace DesignPatterns.UI.Iterator
{
    public class BrowserHistory
    {
        private readonly List<string> _urls = new();

        public string Pop()
        {
            var last = _urls.Last();
            _urls.Remove(last);
            return last;
        }

        public void Push(string url)
        {
            _urls.Add(url);
        }

        public Iterator<string> CreateIterator()
        {
            return new ListIerator(this);
        }

        public class ListIerator : Iterator<string>
        {
            private BrowserHistory _history;
            private int _index;

            public ListIerator(BrowserHistory history)
            {
                _history = history;
            }

            public string Current()
            {
                return _history._urls[_index];
            }

            public bool HasNext()
            {
                return _index < _history._urls.Count;
            }

            public void Next()
            {
                _index++;
            }
        }
    }
}