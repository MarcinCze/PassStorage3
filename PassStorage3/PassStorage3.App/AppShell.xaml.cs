using PassStorage3.App.Pages;
using PassStorage3.App.Services;

namespace PassStorage3.App;

public partial class AppShell : Shell
{
    readonly IAuthenticationService authenticationService;

	public AppShell(IAuthenticationService authenticationService)
	{
        this.authenticationService = authenticationService;

        Routing.RegisterRoute($"{nameof(LoginPage)}", typeof(LoginPage));
        Routing.RegisterRoute($"{nameof(ListPage)}", typeof(ListPage));

        InitializeComponent();
	}
}
