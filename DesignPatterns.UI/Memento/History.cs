namespace DesignPatterns.UI.Memento
{
    public class History
    {
        public List<EditorState> States { get; private set; } = new();

        public void Push(EditorState state)
        {
            States.Add(state);
        }

        public EditorState Pop()
        {
            var last = States.LastOrDefault();

            if(last == default)
            {
                throw new InvalidOperationException("No state to pop from list of state items");
            }

            States.Remove(last);
            return last;
        }
    }
}