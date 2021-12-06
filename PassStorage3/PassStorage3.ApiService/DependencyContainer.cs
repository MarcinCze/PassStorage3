namespace PassStorage3.ApiService
{
    public static class DependencyContainer
    {
        public static void Register(IServiceCollection services)
        {
            services
                .AddSingleton<IPasswordHandler, PasswordHandler>()
                .AddSingleton<IPasswordsHandler, PasswordsHandler>();

            services
                .AddSingleton<IDatabaseReadService, LiteDbReadService>()
                .AddSingleton<IDatabaseWriteService, LiteDbWriteService>();

            services
                .AddSingleton<IDateTimeProvider, DateTimeProvider>();
        }
    }
}
