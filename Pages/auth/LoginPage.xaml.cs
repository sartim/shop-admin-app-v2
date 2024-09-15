namespace ShopAdmin.Pages.auth;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
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
            // bool isAuthenticated = await _authService.Authenticate(email, password);
            bool isAuthenticated = true;
            if (isAuthenticated)
            {
                // Navigate to the home page upon successful login
                await Navigation.PushAsync(new MainPage());
            }
            else
            {
                await DisplayAlert("Invalid credentials", "Please try again", "OK");
            }
        }
        

        // ProgressLoader.IsVisible = false;
    }
}

