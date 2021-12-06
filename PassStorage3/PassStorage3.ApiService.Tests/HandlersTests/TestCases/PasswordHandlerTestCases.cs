namespace ApiService.Tests.HandlersTests.TestCases
{
    internal class PasswordHandlerTestCases
    {
        public static IEnumerable AddPasswordTestCases
        {
            get
            {
                yield return new TestCaseData(new PasswordRequest
                {
                    Login = "test@test.com",
                    Password = "abc123!",
                    Title = "TestPassword",
                    AdditionalData = "This is additional data"
                });
                yield return new TestCaseData(new PasswordRequest
                {
                    Login = "DonTest",
                    Password = "Abc!@#$%^!123",
                    Title = "TestPassword_1"
                });
            }
        }
    }
}
