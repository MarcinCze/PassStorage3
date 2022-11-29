using PassStorage3.App.Pages;
using PassStorage3.App.Services;

namespace PassStorage3.App;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services
			.AddSingleton<AppShell>()
			.RegisterServices()
			.RegisterViews();

		return builder.Build();
	}

	private static IServiceCollection RegisterViews(this IServiceCollection services)
	{
		services
			.AddSingleton<MainPage>()
			.AddSingleton<LoginPage>()
			.AddSingleton<ListPage>();

		return services;
    }

	private static IServiceCollection RegisterServices(this IServiceCollection services)
	{
		services
            .AddSingleton<IAuthenticationService, AuthenticationService>();

		return services;
    }
}
