namespace DesignPatterns.UI.Mediator
{
    public class ArticlesDialogBox
    {
        private ListBox _articleListBox;
        private TextBox _titleTextBox;
        private Button _saveButton;

        public void SimulateUserInteraction()
        {
            _articleListBox.SetSelection("Article 1");
            System.Console.WriteLine("TextBox: " + _titleTextBox.Content);
            System.Console.WriteLine("Button: " + _saveButton.IsEnabled);
        }

        public ArticlesDialogBox()
        {
            _articleListBox = new();
            _articleListBox.Attach(ArticleSelected);
            _titleTextBox = new();
            _titleTextBox.Attach(TitleChanged);
            _saveButton = new();
        }

        private void TitleChanged()
        {
            _saveButton.SetEnabled(!string.IsNullOrWhiteSpace(_titleTextBox.Content));            
        }

        private void ArticleSelected()
        {
            _titleTextBox.SetContent(_articleListBox.Selection);
            _saveButton.SetEnabled(true);
        }
    }
}