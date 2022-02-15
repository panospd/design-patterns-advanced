namespace DesignPatterns.UI.Command.Excercise
{
    public class VideoEditor
    {
        public float Contrast { get; private set; }
        public string Text { get; private set; } = string.Empty;

        public void SetText(string text)
        {
            Text = text;
        }

        public void RemoveText()
        {
            Text = string.Empty;
        }

        public void SetContrast(float contrast)
        {
            Contrast = contrast;
        }
    }
}