namespace PassStorage3.ApiService.Data.Services
{
    public abstract class LiteDbBaseService
    {
        private string? dbFileName;

        protected readonly IDateTimeProvider dateTimeProvider;

        public LiteDbBaseService(IDateTimeProvider dateTimeProvider)
        {
            this.dateTimeProvider = dateTimeProvider;
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

        public void SetDatabaseName(string dbFileName) => this.dbFileName = dbFileName;

    }
}
