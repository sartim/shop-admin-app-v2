using ShopAdminApp.Services;

namespace ShopAdmin;

public partial class LoginPage : ContentPage
{
    private readonly AuthService _authService;
    
	public LoginPage()
	{
		InitializeComponent();
        // ProgressLoader.IsVisible = false;
        EmailEntryLabel.IsVisible = false;
        PasswordEntryLabel.IsVisible = false;

        CheckForJwtAsync();
        _authService = new AuthService();
	}

    async void OnLoginButtonClicked(object sender, EventArgs e)
    {
        // ProgressLoader.IsVisible = true;
        EmailEntryLabel.IsVisible = false;
        PasswordEntryLabel.IsVisible = false;

        string email = EmailEntry.Text;
        string password = PasswordEntry.Text;

        if (email == null)
        {
            EmailEntryLabel.IsVisible = true;
        }

        if (password == null)
        {
            PasswordEntryLabel.IsVisible = true;
        }

        if (email != null && password != null)
        {
            bool isAuthenticated = await _authService.Authenticate(email, password);
            if (isAuthenticated)
            {
                // Navigate to the home page upon successful login
                #pragma warning disable CS8602 // Dereference of a possibly null reference.
                Application.Current.MainPage = new NavigationPage(new AppShell());
            }
            else
            {
                await DisplayAlert("Invalid credentials", "Please try again", "OK");
            }
        }
        

        // ProgressLoader.IsVisible = false;
    }
    async void CheckForJwtAsync()
    {
        try
        {
            var jwt = await SecureStorage.GetAsync("jwt");

            if (!string.IsNullOrEmpty(jwt))
            {   
                #pragma warning disable CS8602 // Dereference of a possibly null reference.
                Application.Current.MainPage = new NavigationPage(new AppShell());
            }
        }
        catch (Exception ex)
        {
            // Possible that device doesn't support secure storage on device.
            await DisplayAlert("Error", ex.Message, "OK");
            // Navigate to the login page
            #pragma warning disable CS8602 // Dereference of a possibly null reference.
            Application.Current.MainPage = new NavigationPage(new LoginPage());
        }
    }
}

