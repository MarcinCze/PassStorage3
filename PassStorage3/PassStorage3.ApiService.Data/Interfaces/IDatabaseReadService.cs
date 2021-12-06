namespace PassStorage3.ApiService.Data.Interfaces
{
    public interface IDatabaseReadService
    {
        Task<IEnumerable<PasswordEntity>> ReadAllAsync();
    }
}
