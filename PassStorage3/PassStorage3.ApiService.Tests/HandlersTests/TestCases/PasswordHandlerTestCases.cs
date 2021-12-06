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

        public static IEnumerable AddPasswordFailureTestCases
        {
            get
            {
                yield return new TestCaseData(new PasswordRequest
                {
                    Password = "abc123!",
                    Title = "TestPassword",
                    AdditionalData = "This is additional data"
                });
                yield return new TestCaseData(new PasswordRequest
                {
                    Login = "DonTest",
                    Title = "TestPassword_1"
                });
                yield return new TestCaseData(new PasswordRequest
                {
                    Password = "abc123!",
                    Login = "DonTest",
                });
                yield return new TestCaseData(new PasswordRequest
                {
                    Login = new string('a', 1000),
                    Password = "abc123!",
                    Title = "TestPassword",
                    AdditionalData = "This is additional data"
                });
                yield return new TestCaseData(new PasswordRequest
                {
                    Login = "test@test.com",
                    Password = new string('a', 1000),
                    Title = "TestPassword",
                    AdditionalData = "This is additional data"
                });
                yield return new TestCaseData(new PasswordRequest
                {
                    Login = "test@test.com",
                    Password = "abc123",
                    Title = new string('a', 1000),
                    AdditionalData = "This is additional data"
                });
                yield return new TestCaseData(new PasswordRequest
                {
                    Login = "DonTest",
                    Password = "Abc!@#$%^!123",
                    Title = "TestPassword_1",
                    AdditionalData = new string('a', 1000)
                });
            }
        }
    }
}
