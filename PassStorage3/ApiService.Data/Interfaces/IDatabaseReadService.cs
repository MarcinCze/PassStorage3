namespace ApiService.Data.Interfaces
{
    public interface IDatabaseReadService
    {
        Task<IEnumerable<PasswordEntity>> ReadAllAsync();
    }
}
