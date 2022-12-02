namespace PassStorage3.Crypto
{
    public interface IDecrypt : ISymmetricCryptoAlgorithm
    {
        string Decrypt(string encodedText);
    }
}
