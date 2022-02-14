namespace DesignPatterns.UI.Strategy.Excercise.Encryption
{
    public class AESEncryption : IEncryptionAlgorithm
    {
        public string Encrypt(string message)
        {
            System.Console.WriteLine("Encrypting message using AES");
            return message + "_AES_encrypted";
        }
    }
}