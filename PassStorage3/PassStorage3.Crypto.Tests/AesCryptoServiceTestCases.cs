namespace PassStorage3.Crypto.Tests
{
    internal class AesCryptoServiceTestCases
    {
        public static readonly object[] SetKeysTestCases =
        {
            new object[] { "abc123", "12345678" },
            new object[] { "!@#$as", "@#$#@!SD" },
            new object[] { "abc", "abc" },
            new object[] { "", "" },
            new object[] { null, null },
        };
    }
}
