using PassStorage3.App.Services;

namespace PassStorage3.App.Pages;

public partial class LoginPage : ContentPage
{
    private readonly IAuthenticationService authenticationService;

	public LoginPage(IAuthenticationService authenticationService)
	{
		InitializeComponent();

        this.authenticationService = authenticationService;
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        authenticationService.Authenticate(
            entryPassword1.Text,
            entryPassword2.Text);

        await Shell.Current.GoToAsync($"{nameof(ListPage)}", true);
    }
}