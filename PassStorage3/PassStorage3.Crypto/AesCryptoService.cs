using System.Security.Cryptography;
using System.Text;

namespace PassStorage3.Crypto
{
    public class AesCryptoService : IEncrypt, IDecrypt
    {
        public const int KeySize = 256;
        public const int BlockSize = 128;
        public const int Iterations = 1000;

        public byte[] Key { get; protected set; }
        public byte[] IV { get;protected set; }

        public void SetKeys(string firstKey, string secondKey)
        {
            if (string.IsNullOrEmpty(firstKey))
                throw new ArgumentNullException(nameof(firstKey));

            if (string.IsNullOrEmpty(secondKey))
                throw new ArgumentNullException(nameof(secondKey));

            Key = SHA256
                .Create()
                .ComputeHash(
                    Encoding.UTF8.GetBytes(firstKey)
                    );

            IV = Encoding.UTF8.GetBytes(secondKey);
        }

        public string Decrypt(string encodedText)
        {
            throw new NotImplementedException();
        }

        public string Encrypt(string plainText)
        {
            throw new NotImplementedException();
        }
    }
}
