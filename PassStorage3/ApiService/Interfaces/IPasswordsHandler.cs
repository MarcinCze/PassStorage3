namespace ApiService.Interfaces
{
    public interface IPasswordsHandler
    {
        Task<IEnumerable<RoughPasswordResponse>> GetRoughListAsync();
    }
}
