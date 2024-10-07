using ShopAdminApp.Services;

namespace ShopAdmin;

public partial class LoginPage : ContentPage
{
    private readonly AuthService _authService;
    
	public LoginPage()
	{
		InitializeComponent();
        CheckForJwtAsync();
        _authService = new AuthService();
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

