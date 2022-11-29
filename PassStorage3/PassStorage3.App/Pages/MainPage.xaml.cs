using PassStorage3.App.Services;

namespace PassStorage3.App.Pages;

public partial class MainPage : ContentPage
{
	private readonly IAuthenticationService authenticationService;

	public MainPage(IAuthenticationService authenticationService)
	{
		InitializeComponent();

		this.authenticationService = authenticationService;
	}

	private async void OnLoginClicked(object sender, EventArgs e)
	{
		if (authenticationService.IsAuthenticated)
            await Shell.Current.GoToAsync($"{nameof(ListPage)}", true);
        else
            await Shell.Current.GoToAsync($"{nameof(LoginPage)}", true);
    }
}

