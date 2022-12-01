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

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        //if (authenticationService.IsAuthenticated)
        //{
        //    await Shell.Current.GoToAsync($"///{nameof(MainPage)}", true);
        //}
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        try
        {
            authenticationService.Authenticate(
            entryPassword1.Text,
            entryPassword2.Text);

            await Shell.Current.GoToAsync($"/{nameof(ListPage)}", true);
        }
        catch (Exception ex)
        {
            labelFrameMsgError.Text = ex.Message;
            frameMsgError.IsVisible = true;
        }
    }
}