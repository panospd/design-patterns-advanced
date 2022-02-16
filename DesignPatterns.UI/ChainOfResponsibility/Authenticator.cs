namespace DesignPatterns.UI.ChainOfResponsibility
{
    public class Authenticator : Handler
    {
        public Authenticator(Handler? next) 
            : base(next)
        {
        }

        public override bool DoHandle(HttpRequest request)
        {
            System.Console.WriteLine("Authentication");
            var authSucessful = request.Username == "admin" && request.Password == "1234";

            return !authSucessful;
        }
    }
}