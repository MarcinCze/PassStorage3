namespace ApiService.Data.Services
{
    public class LiteDbWriteService : LiteDbBaseService, IDatabaseWriteService
    {
        public LiteDbWriteService() { }
        public LiteDbWriteService(string dbFileName) : base(dbFileName) { }

        public async Task<Guid> AddAsync(PasswordEntity passwordEntity)
        {
            using var db = new LiteDatabase(ConnString);
            var col = db.GetCollection<PasswordEntity>("passwords");

            passwordEntity.ViewsCounter = 0;
            passwordEntity.Created = DateTime.Now;
            passwordEntity.PasswordChanged = DateTime.Now;

            var docId = await Task.FromResult(col.Insert(passwordEntity));

            return docId.IsGuid 
                ? docId.AsGuid 
                : throw new Exception("Entity maybe was saved but there was no response from db");
        }
    }
}
