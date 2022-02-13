namespace DesignPatterns.UI.Memento
{
    public class EditorState
    {
        public string Content { get; private set; }

        public EditorState(string content)
        {
            Content = content;
        }
    }
}