namespace DesignPatterns.UI.Memento
{
    public class Editor
    {
        public string Content { get; private set; } = string.Empty;

        public Editor()
        {
        }

        public Editor(string content)
        {
            Content = content;
        }

        public void SetContent(string content)
        {
            Content = content;
        }

        public EditorState CreateState()
        {
            return new EditorState(Content);
        }

        public void Restore(EditorState state)
        {
            Content = state.Content;
        }
    }
}