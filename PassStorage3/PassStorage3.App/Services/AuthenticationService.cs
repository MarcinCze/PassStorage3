namespace PassStorage3.App.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private string firstPassword, secondPassword;

        public bool IsAuthenticated => !string.IsNullOrEmpty(firstPassword) && !string.IsNullOrEmpty(secondPassword);

        public void Authenticate(string firstPassword, string secondPassword)
        {
            this.firstPassword = firstPassword;
            this.secondPassword = secondPassword;
        }
    }
}
