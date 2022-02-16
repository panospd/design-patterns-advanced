namespace DesignPatterns.UI.ChainOfResponsibility
{
    public class Compressor : Handler
    {
        public Compressor(Handler? next) 
            : base(next)
        {
        }

        public override bool DoHandle(HttpRequest request)
        {
            System.Console.WriteLine("Compress");
            return false;
        }
    }
}