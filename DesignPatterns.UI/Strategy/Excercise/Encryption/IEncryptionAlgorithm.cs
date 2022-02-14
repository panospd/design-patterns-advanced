namespace DesignPatterns.UI.Strategy.Excercise.Encryption
{
    public interface IEncryptionAlgorithm
    {
        string Encrypt(string message);
    }
}