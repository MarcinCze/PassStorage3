namespace ApiService.Interfaces
{
    public interface IPasswordHandler
    {
        Task<SavedPasswordResponse> AddAsync(PasswordRequest password);
    }
}
