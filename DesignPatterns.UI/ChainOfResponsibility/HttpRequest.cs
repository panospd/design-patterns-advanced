namespace DesignPatterns.UI.ChainOfResponsibility
{
    public class HttpRequest
    {
        public string Username { get; }
        public string Password { get; }

        public HttpRequest(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}