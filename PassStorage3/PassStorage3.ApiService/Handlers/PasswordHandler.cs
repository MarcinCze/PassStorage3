namespace PassStorage3.ApiService.Handlers
{
    public class PasswordHandler : IPasswordHandler
    {
        private readonly IDatabaseWriteService databaseWriteService;

        public PasswordHandler(IDatabaseWriteService databaseWriteService)
        {
            this.databaseWriteService = databaseWriteService;
        }

        public async Task<SavedPasswordResponse> AddAsync(PasswordRequest password)
        {
            if (!password.IsValid)
                throw new ValidationException();

            return new() { Id = await databaseWriteService.AddAsync(password.ToEntityModel()) };
        }
            
    }
}
