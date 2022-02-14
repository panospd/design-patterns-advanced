namespace DesignPatterns.UI.Strategy.Excercise.Encryption
{
    public class DESEncryption : IEncryptionAlgorithm
    {
        public string Encrypt(string message)
        {
            System.Console.WriteLine("Encrypting message using DES");
            return message + "_DES_encrypted";
        }
    }
}