namespace ApiService.Data.Services
{
    public class LiteDbReadService : LiteDbBaseService, IDatabaseReadService
    {
        public LiteDbReadService() { }
        public LiteDbReadService(string dbFileName) : base(dbFileName) { }

        public async Task<IEnumerable<PasswordEntity>> ReadAllAsync()
        {
            using var db = new LiteDatabase(ConnString);
            var col = db.GetCollection<PasswordEntity>("passwords");
            var results = col.FindAll().ToList();

            if (results == null)
                return new List<PasswordEntity>();
            else
                return await Task.FromResult(results);
        }
    }
}
