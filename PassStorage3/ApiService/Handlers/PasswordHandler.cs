namespace ApiService.Handlers
{
    public class PasswordHandler : IPasswordHandler
    {
        private readonly IDatabaseWriteService databaseWriteService;

        public PasswordHandler(IDatabaseWriteService databaseWriteService)
        {
            this.databaseWriteService = databaseWriteService;
        }

        public async Task<SavedPasswordResponse> AddAsync(PasswordRequest password) => 
            new() { Id = await databaseWriteService.AddAsync(password.ToEntityModel()) };
    }
}
