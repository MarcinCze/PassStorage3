namespace PassStorage3.ApiService.Data.Services
{
    public class LiteDbWriteService : LiteDbBaseService, IDatabaseWriteService
    {
        public LiteDbWriteService(IDateTimeProvider dateTimeProvider) : base(dateTimeProvider) { }

        public async Task<Guid> AddAsync(PasswordEntity passwordEntity)
        {
            using var db = new LiteDatabase(ConnString);
            var col = db.GetCollection<PasswordEntity>("passwords");

            passwordEntity.ViewsCounter = 0;
            passwordEntity.Created = dateTimeProvider.Now;
            passwordEntity.PasswordChanged = dateTimeProvider.Now;

            var docId = await Task.FromResult(col.Insert(passwordEntity));

            return docId.IsGuid 
                ? docId.AsGuid 
                : throw new Exception("Entity maybe was saved but there was no response from db");
        }
    }
}
