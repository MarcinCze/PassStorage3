namespace PassStorage3.ApiService.Interfaces
{
    public interface IPasswordsHandler
    {
        Task<IEnumerable<RoughPasswordResponse>> GetRoughListAsync();
    }
}
