namespace PassStorage3.App;

public partial class App : Application
{
	public App(AppShell appShell)
	{
		InitializeComponent();

		MainPage = appShell;
	}

    protected override Window CreateWindow(IActivationState activationState)
    {
		var window = base.CreateWindow(activationState);

        window.Width = 1000;
        window.Height = 600;

        window.MinimumWidth = 1000;
        window.MinimumHeight = 600;

        /* TODO: TO BE FIXED */
        var screenWidth = 1920;
        var screenHeight = 1080;
		
        window.X = (screenWidth / 2) - (window.Width / 2);
		window.Y = (screenHeight / 2) - (window.Height / 2);

		return window;
    }
}
