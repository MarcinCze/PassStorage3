namespace ApiService.Data.Services
{
    public abstract class LiteDbBaseService
    {
        private readonly string dbFileName;

        public LiteDbBaseService(string dbFileName = "")
        {
            this.dbFileName = dbFileName;
        }

        public ConnectionString ConnString => new()
        {
            Filename = string.IsNullOrEmpty(dbFileName) ? "PassStorage3_db.db" : dbFileName,
            Connection = ConnectionType.Direct,
            Password = null,
            InitialSize = 0,
            ReadOnly = false,
            Upgrade = false
        };
    }
}
