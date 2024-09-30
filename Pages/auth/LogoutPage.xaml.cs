namespace ShopAdmin
{
    public partial class LogoutPage : ContentPage
    {
        public LogoutPage()
        {
            InitializeComponent();
            Logout();
        }

        async void Logout()
        {
            SecureStorage.Remove("jwt");
            #pragma warning disable CS8602 // Dereference of a possibly null reference.
            Application.Current.MainPage = new NavigationPage(new LoginPage());
        }
    }
}

