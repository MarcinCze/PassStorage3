namespace PassStorage3.ApiService.Handlers
{
    public class PasswordsHandler : IPasswordsHandler
    {
        private readonly IDatabaseReadService databaseReadService;

        public PasswordsHandler(IDatabaseReadService databaseReadService)
        {
            this.databaseReadService = databaseReadService;
        }

        public async Task<IEnumerable<RoughPasswordResponse>> GetRoughListAsync() =>
            (await databaseReadService.ReadAllAsync()).Select(dbPass => new RoughPasswordResponse()
            {
                Id = dbPass.Id,
                Title = dbPass.Title,
                PasswordChanged = dbPass.PasswordChanged.HasValue ? dbPass.PasswordChanged.Value : DateTime.MinValue,
                ExpirationAlert = dbPass.ExpirationAlert
            });
    }
}
