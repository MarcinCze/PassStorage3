namespace PassStorage3.Crypto
{
    public interface ISymmetricCryptoAlgorithm
    {
        void SetKeys(string firstKey, string secondKey);
    }
}
