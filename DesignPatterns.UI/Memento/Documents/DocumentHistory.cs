namespace DesignPatterns.UI.Memento.Documents
{
    public class DocumentHistory
    {
        public List<DocumentState> States { get; } = new();

        public void Push(DocumentState state)
        {
            States.Add(state);
        }

        public DocumentState Pop()
        {
            var last = States.LastOrDefault();

            if (last == default)
            {
                throw new InvalidOperationException("No document history");
            }

            States.Remove(last);

            return last;
        }
    }
}