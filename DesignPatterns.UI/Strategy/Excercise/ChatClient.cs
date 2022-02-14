using DesignPatterns.UI.Strategy.Excercise.Encryption;

namespace DesignPatterns.UI.Strategy.Excercise
{
    public class ChatClient
    {
        public void Send(string message, IEncryptionAlgorithm encryptionAlgorithm)
        {
            var encryptedMessage = encryptionAlgorithm.Encrypt(message);
            System.Console.WriteLine($"Sending message {encryptedMessage}");
        }
    }
}