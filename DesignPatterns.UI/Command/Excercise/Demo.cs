using DesignPatterns.UI.Command.Excercise.Commands;

namespace DesignPatterns.UI.Command.Excercise
{
    public class Demo
    {
        public void Main()
        {
            var videoEditor = new VideoEditor();
            var history = new History();

            var setContrastCommand = new SetContrastCommand(1, videoEditor, history);
            setContrastCommand.Execute();

            var setTextCommand = new SetTextCommand("Video Title", videoEditor, history);
            setTextCommand.Execute();

            var undoCommand = new UndoCommand(history);

            undoCommand.Execute();
        }
    }
}