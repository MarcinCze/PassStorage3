namespace ApiService
{
    public static class DependencyContainer
    {
        public static void Register(IServiceCollection services)
        {
            services.AddSingleton<IPasswordHandler, PasswordHandler>();
            services.AddSingleton<IPasswordsHandler, PasswordsHandler>();
        }
    }
}
