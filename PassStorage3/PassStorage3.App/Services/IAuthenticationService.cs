namespace PassStorage3.App.Services
{
    public interface IAuthenticationService
    {
        bool IsAuthenticated { get; }

        void Authenticate(string firstPassword, string secondPassword);
    }
}
