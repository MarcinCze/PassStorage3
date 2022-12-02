namespace PassStorage3.Crypto
{
    public interface IEncrypt : ISymmetricCryptoAlgorithm
    {
        string Encrypt(string plainText);
    }
}
