namespace DesignPatterns.UI.ChainOfResponsibility
{
    public class Demo
    {
        public void Main()
        {
            var compressor = new Compressor(null);
            var logger = new Logger(compressor);
            var authenticator = new Authenticator(logger);

            var webServer = new WebServer(authenticator);

            webServer.Handle(new HttpRequest("admin", "1234"));
        }
    }
}