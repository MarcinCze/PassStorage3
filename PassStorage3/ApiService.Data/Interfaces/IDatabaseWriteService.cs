namespace ApiService.Data.Interfaces
{
    public interface IDatabaseWriteService
    {
        Task<Guid> AddAsync(PasswordEntity passwordEntity);
    }
}
