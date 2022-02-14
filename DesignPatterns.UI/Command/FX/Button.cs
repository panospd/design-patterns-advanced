namespace DesignPatterns.UI.Command.FX
{
    public class Button
    {
        private ICommand _command;

        public Button(ICommand command)
        {
            _command = command;
        }

        public string Label { get; set; } = string.Empty;

        public void Click()
        {
            _command.Execute();
        }
    }
}