using Newtonsoft.Json;
using ShopAdminApp.Models;
using ShopAdminApp.Services;

namespace ShopAdmin
{
    public partial class StatusPage : ContentPage
    {
        private readonly RestService _restService;

        public StatusPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            _restService = new RestService();
            GetStatus();
        }

        public async void GetStatus()
        {
            try
            {
                if (NetworkCheck.IsInternet())
                {
                    string storedAuthResponse = await SecureStorage.GetAsync("jwt");
                    AuthResponse authResponse = JsonConvert.DeserializeObject<AuthResponse>(storedAuthResponse);
                    string token = authResponse.access_token;
                    var statuses = await _restService.GetAsync<Status>("api/v1/statuses", token);
                    listviewStatuses.ItemsSource = statuses.results;
                }
                else
                {
                    await DisplayAlert("JSONParsing", "No network is available.", "Ok");
                }
                ProgressLoader.IsVisible = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Failed to load statuses: {ex.Message}", "OK");
                ProgressLoader.IsVisible = false;
            }
        }
    }
}

