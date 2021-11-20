namespace ApiService.Data.Services
{
    public class LiteDbReadService : LiteDbBaseService, IDatabaseReadService
    {
        public LiteDbReadService() { }
        public LiteDbReadService(string dbFileName) : base(dbFileName) { }
    }
}
